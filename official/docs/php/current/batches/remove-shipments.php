<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$batch = $client->batch->retrieve('batch_...');

$batchWithoutShipments = $client->batch->removeShipments(
    $shipment->id,
    [
        'shipments' => [
            ['id' => 'shp_...']
        ]
    ]
);

echo $batchWithoutShipments;
