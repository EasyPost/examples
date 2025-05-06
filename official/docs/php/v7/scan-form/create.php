<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$scanForm = $client->scanForm->create([
    'shipments' => [
        ['id' => 'shp_...'],
        ['id' => 'shp_...'],
    ]
]);

echo $scanForm;
