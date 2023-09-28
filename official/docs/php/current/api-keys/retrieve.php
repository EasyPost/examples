<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

// Retrieve all API keys (authenticated user and child user keys)
$apiKeys = $client->apiKeys->all();

echo $apiKeys;

// Retrieve API keys for a child user
$childUser = $client->user->retrieve('user_...');
$childApiKeys = $client->apiKeys->retrieveApiKeysForUser($childUser->id);

echo $childApiKeys;
