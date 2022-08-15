<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$scanForm = \EasyPost\ScanForm::create([
    'shipments' => [
        [
            'id' => 'shp_...'
        ],
        [
            'id' => 'shp_...'
        ]
    ]
]);

echo $scanForm;
