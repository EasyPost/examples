<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$createdBatch = $client->batch->create([
    'shipments' => [
        ['from_address' => ['id' => 'adr_...']],
        ['to_address' => ['id' => 'adr_...']],
        ['parcel' => ['id' => 'prcl_...']],
        ['service' => 'First'],
        ['carrier' => 'USPS'],
        ['carrier_accounts' => ['ca_...']],
    ]
]);

$batch = $client->batch->buy($createdBatch['id']);

echo $batch;
