<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$carrierAccount = $client->carrierAccount->retrieve('ca_...');

$updatedCarrierAccount = $client->$carrierAccount->update(
    $carrierAccount->id,
    ['pickup_id' => 'abc123']
);

echo $updatedCarrierAccount;
