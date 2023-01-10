<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$batch = $client->batch->retrieve('batch_...');

$batchWithShipments = $client->$batch->addShipments(
    $batch->id,
    [
        'shipments' => [
            ['id' => 'shp_...'],
            ['id' => 'shp_...'],
        ]
    ]
);

echo $batchWithShipments;
