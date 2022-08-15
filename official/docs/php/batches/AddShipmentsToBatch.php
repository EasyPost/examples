<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$params = [
    'shipments' => [
        [
            'id' => 'shp_...'
        ],
        [
            'id' => 'shp_...'
        ]
    ]
];

$batch = \EasyPost\Batch::retrieve('batch_...');

$batch->add_shipments($params);

echo $batch;
