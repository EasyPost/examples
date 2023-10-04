<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

// Retrieve all API keys including children
$apiKeys = $client->apiKeys->all();

echo $apiKeys;

// Retrieve API keys for a specific child user
$childUser = $client->user->retrieve('user_...');
$childApiKeys = $client->apiKeys->retrieveApiKeysForUser($childUser->id);

echo $childApiKeys;
