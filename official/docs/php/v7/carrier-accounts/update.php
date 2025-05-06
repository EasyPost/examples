<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$carrierAccount = $client->carrierAccount->update(
    'ca_...',
    [
        'description' => 'FL Location DHL eCommerce Solutions Account',
        'credentials' => [
            'pickup_id' => 'abc123',
        ]
    ]
);

echo $carrierAccount;
