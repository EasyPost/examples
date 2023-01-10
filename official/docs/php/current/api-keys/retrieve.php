<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

// Retrieve all API keys (authenticated user and child user keys)
$apiKeys = $client->user->allApiKeys();

// Retrieve API keys for a child user
$childUser = $client->user->retrieve('user_...');
$apiKeys = $client->$user->apiKeys($childUser->id);

echo $apiKeys;
