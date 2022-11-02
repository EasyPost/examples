<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$carrierAccount = \EasyPost\CarrierAccount::create([
    'type' => 'DhlEcsAccount',
    'description' => 'CA Location DHL eCommerce Solutions Account',
    'credentials' => [
        'client_id' => '123456',
        'client_secret' => '123abc',
        'distribution_center' => 'USLAX1',
        'pickup_id' => '123456'
    ],
    'test_credentials' => [
        'client_id' => '123456',
        'client_secret' => '123abc',
        'distribution_center' => 'USLAX1',
        'pickup_id' => '123456'
    ]
]);

echo $carrierAccount;
