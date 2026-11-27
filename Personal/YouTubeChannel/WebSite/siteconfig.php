<?php

//reads siteconfig.json (deployed alongside the site) once per request
function getSiteConfig(): array
{
    static $config = null;
    if ($config === null)
    {
        $configFile = __DIR__ . '/siteconfig.json';
        $json = file_get_contents($configFile);
        if ($json === false)
        {
            throw new RuntimeException("Could not read site config file " . $configFile);
        }
        $config = json_decode($json, true, 512, JSON_THROW_ON_ERROR);
    }
    return $config;
}

//minutes to cache the AWS secret in APCu; 0 turns caching off
function getAwsSecretsCacheTTLMinutes(): int
{
    $ttl = getSiteConfig()['awsSecretsCacheTTLMinutes'] ?? null;
    if (!is_int($ttl) || $ttl < 0)
    {
        throw new RuntimeException("awsSecretsCacheTTLMinutes in siteconfig.json must be a non-negative integer");
    }
    return $ttl;
}

//number of records to show per page on paginated pages
function getPaginationRecordCount(): int
{
    $count = getSiteConfig()['paginationRecordCount'] ?? null;
    if (!is_int($count) || $count <= 0)
    {
        throw new RuntimeException("paginationRecordCount in siteconfig.json must be a positive integer");
    }
    return $count;
}
