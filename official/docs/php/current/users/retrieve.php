<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

// Retrieve the authenticated user
$user = $client->user->retrieveMe();

// Retrieve a child user
$user = $client->user->retrieve('user_...');

echo $user;
