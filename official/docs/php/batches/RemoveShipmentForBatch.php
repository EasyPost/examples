<?php

\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$params = [
    'shipments' => [
        ['id' => 'shp_...']
    ]
];

$batch = \EasyPost\Batch::retrieve('batch_...');

$batch->remove_shipments($params);

echo $batch;
