<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$batch = $client->batch->retrieve('batch_...');

$batchWithoutShipments = $batch->remove_shipments([
    'shipments' => [
        ['id' => 'shp_...']
    ]
]);

echo $batchWithoutShipments;
