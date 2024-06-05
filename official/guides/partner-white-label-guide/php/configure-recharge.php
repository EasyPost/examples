<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$user = $client->user->retrieveMe();

$updatedUser = $client->user->update(
    $user->id,
    ['recharge_threshold' => '50.00']
);

echo $updatedUser;
