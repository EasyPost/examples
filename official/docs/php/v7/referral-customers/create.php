<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$referralUser = $client->referralCustomer->create([
    'name' => 'Test Referral',
    'email' => 'test@test.com',
    'phone' => '8888888888'
]);

echo $referralUser;
