<?php
use Aws\SecretsManager\SecretsManagerClient;

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
            require_once __DIR__ . '/vendor/autoload.php';

            $client = new SecretsManagerClient([
                'version' => 'latest',
                'region'  => 'us-east-2'
            ]);

            $result = $client->getSecretValue([
                'SecretId' => 'DestroyAllPugsSiteSecrets'
            ]);

            $json = $result['SecretString'];
        }

        $secrets = json_decode($json, true, 512, JSON_THROW_ON_ERROR);
    }
    return $secrets;
}

function getPgConnectionString(): string
{
    $secrets = getSecrets();
    $dbPassword = $secrets['PGSQL_DB_PASSWORD'];

    //libpq connection strings need single quotes and backslashes escaped inside a quoted value
    $escapedPassword = str_replace(['\\', "'"], ['\\\\', "\\'"], $dbPassword);

    return "host=localhost port={pgconnport} dbname=DestroyAllPugs user={pgconnuser} password='" . $escapedPassword . "'";
}
