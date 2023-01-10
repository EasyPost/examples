<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$batch = \EasyPost\Batch::retrieve('batch_...');

$batch->add_shipments([
    'shipments' => [
        ['id' => 'shp_...'],
        ['id' => 'shp_...'],
    ]
]);

echo $batch;
