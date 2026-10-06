<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$accountLink = $client->customerPortal->createAccountLink([
    'session_type' => 'account_management',
    'user_id' => 'user_...',
    'refresh_url' => 'https://example.com/refresh',
    'return_url' => 'https://example.com/return',
    'metadata' => ['target' => 'wallet'],
]);

echo $accountLink;
