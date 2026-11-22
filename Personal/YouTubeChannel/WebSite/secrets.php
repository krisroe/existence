<?php
require_once __DIR__ . '/vendor/autoload.php';

use Aws\SecretsManager\SecretsManagerClient;

function getSecrets(): array
{
    static $secrets = null;
    if ($secrets === null)
    {
        $client = new SecretsManagerClient([
            'version' => 'latest',
            'region'  => 'us-east-2'
        ]);

        $result = $client->getSecretValue([
            'SecretId' => 'DestroyAllPugsSiteSecrets'
        ]);

        $secrets = json_decode($result['SecretString'], true, 512, JSON_THROW_ON_ERROR);
    }
    return $secrets;
}

function getPgConnectionString(): string
{
    $secrets = getSecrets();
    $dbPassword = $secrets['PGSQL_DB_PASSWORD'];

    //libpq connection strings need single quotes and backslashes escaped inside a quoted value
    $escapedPassword = str_replace(['\\', "'"], ['\\\\', "\\'"], $dbPassword);

    return "host=localhost port={pgconnport} dbname=DestroyAllPugs user=postgres password='" . $escapedPassword . "'";
}
