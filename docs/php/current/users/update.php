<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$user = $client->user->update(
    'user_...',
    ['recharge_threshold' => '50.00']
);

echo $user;
