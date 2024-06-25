<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$batch = $client->batch->removeShipments(
    'batch_...',
    [
        'shipments' => [
            ['id' => 'shp_...']
        ]
    ]
);

echo $batch;
