<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$batch = $client->batch->create([
    'shipments' => [
        ['id' => 'shp_...'],
        ['id' => 'shp_...'],
    ]
]);

echo $batch;
