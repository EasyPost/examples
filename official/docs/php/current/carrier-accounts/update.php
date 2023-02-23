<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$carrierAccount = $client->carrierAccount->retrieve('ca_...');

$updatedCarrierAccount = $client->carrierAccount->update(
    $carrierAccount->id,
    [
        'description' => 'FL Location DHL eCommerce Solutions Account',
        'credentials' => [
            'pickup_id' => 'abc123',
        ]
    ]
);

echo $updatedCarrierAccount;
