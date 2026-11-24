<?php
use Aws\SecretsManager\SecretsManagerClient;

require_once __DIR__ . '/siteconfig.php';

const SECRETS_CACHE_KEY = 'DestroyAllPugsSiteSecrets';

//$forceRefresh skips both the per-request and APCu caches and re-reads the secret from its source
function getSecrets(bool $forceRefresh = false): array
{
    static $secrets = null;
    if ($secrets === null || $forceRefresh)
    {
        //local deploys read a JSON file in the same format as the AWS secret; remote deploys leave this blank
        $localSecretsFile = '{localsecretsfile}';
        if ($localSecretsFile !== '')
        {
            $json = file_get_contents($localSecretsFile);
            if ($json === false)
            {
                throw new RuntimeException("Could not read local secrets file " . $localSecretsFile);
            }
            $secrets = json_decode($json, true, 512, JSON_THROW_ON_ERROR);
        }
        else
        {
            //cache the AWS secret in APCu across requests so every page load doesn't call Secrets Manager;
            //apcu_entry locks while fetching, so an expired entry is only refetched by one worker.
            //a TTL of 0 skips the cache (APCu would treat 0 as "never expire")
            $ttlMinutes = getAwsSecretsCacheTTLMinutes();
            if ($ttlMinutes > 0 && function_exists('apcu_entry') && apcu_enabled())
            {
                if ($forceRefresh)
                {
                    apcu_delete(SECRETS_CACHE_KEY);
                }
                $secrets = apcu_entry(SECRETS_CACHE_KEY, 'fetchAwsSecrets', $ttlMinutes * 60);
            }
            else
            {
                $secrets = fetchAwsSecrets();
            }
        }
    }
    return $secrets;
}

function fetchAwsSecrets(): array
{
    require_once __DIR__ . '/vendor/autoload.php';

    $client = new SecretsManagerClient([
        'version' => 'latest',
        'region'  => 'us-east-2'
    ]);

    $result = $client->getSecretValue([
        'SecretId' => 'DestroyAllPugsSiteSecrets'
    ]);

    return json_decode($result['SecretString'], true, 512, JSON_THROW_ON_ERROR);
}

function getPgConnectionString(bool $forceRefresh = false): string
{
    $secrets = getSecrets($forceRefresh);
    $dbPassword = $secrets['PGSQL_DB_PASSWORD'];

    //libpq connection strings need single quotes and backslashes escaped inside a quoted value
    $escapedPassword = str_replace(['\\', "'"], ['\\\\', "\\'"], $dbPassword);

    return "host=localhost port={pgconnport} dbname=DestroyAllPugs user={pgconnuser} password='" . $escapedPassword . "'";
}

//connects to the site database. If the password is rejected (e.g. it was rotated while the old one
//was still cached), the secrets are refreshed from their source and the connection is retried once.
function connectToDatabase(): PgSql\Connection
{
    $error = null;
    $dbconn = tryPgConnect(getPgConnectionString(), $error);
    if ($dbconn === false && str_contains($error, 'password authentication failed'))
    {
        $dbconn = tryPgConnect(getPgConnectionString(true), $error);
    }
    if ($dbconn === false)
    {
        throw new RuntimeException("Could not connect to the database: " . $error);
    }
    return $dbconn;
}

//pg_connect reports failures only as a warning, so capture the warning text for the caller to inspect
function tryPgConnect(string $connectionString, ?string &$error): PgSql\Connection|false
{
    error_clear_last();
    $dbconn = @pg_connect($connectionString);
    $error = $dbconn === false ? (error_get_last()['message'] ?? 'unknown error') : null;
    return $dbconn;
}
