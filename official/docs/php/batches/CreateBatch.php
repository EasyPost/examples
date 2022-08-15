<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$batch = \EasyPost\Batch::create([
    'shipments' => [
        ['id' => 'shp_...'],
        ['id' => 'shp_...']
    ]
]);

echo $batch;
