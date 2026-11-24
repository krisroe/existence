<?php
use Aws\SecretsManager\SecretsManagerClient;

require_once __DIR__ . '/siteconfig.php';

const SECRETS_CACHE_KEY = 'DestroyAllPugsSiteSecrets';

function getSecrets(): array
{
    static $secrets = null;
    if ($secrets === null)
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
        }
        else
        {
            //cache the AWS secret in APCu across requests so every page load doesn't call Secrets Manager;
            //apcu_entry locks while fetching, so an expired entry is only refetched by one worker.
            //a TTL of 0 skips the cache (APCu would treat 0 as "never expire")
            $ttlMinutes = getAwsSecretsCacheTTLMinutes();
            if ($ttlMinutes > 0 && function_exists('apcu_entry') && apcu_enabled())
            {
                $secrets = apcu_entry(SECRETS_CACHE_KEY, 'fetchAwsSecrets', $ttlMinutes * 60);
            }
            else
            {
                $secrets = fetchAwsSecrets();
            }
            return $secrets;
        }

        $secrets = json_decode($json, true, 512, JSON_THROW_ON_ERROR);
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

function getPgConnectionString(): string
{
    $secrets = getSecrets();
    $dbPassword = $secrets['PGSQL_DB_PASSWORD'];

    //libpq connection strings need single quotes and backslashes escaped inside a quoted value
    $escapedPassword = str_replace(['\\', "'"], ['\\\\', "\\'"], $dbPassword);

    return "host=localhost port={pgconnport} dbname=DestroyAllPugs user={pgconnuser} password='" . $escapedPassword . "'";
}
