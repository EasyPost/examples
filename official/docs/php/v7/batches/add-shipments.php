<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$batch = $client->batch->addShipments(
    'batch_...',
    [
        'shipments' => [
            ['id' => 'shp_...'],
            ['id' => 'shp_...'],
        ]
    ]
);

echo $batch;
