<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

// Retrieve all API keys (authenticated user and child user keys)
$apiKeys = \EasyPost\User::all_api_keys();

// Retrieve API keys for a child user
$childUser = \EasyPost\User::retrieve('user_...');
$apiKeys = $childUser->api_keys();

echo $apiKeys;
