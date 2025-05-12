<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$results = $client->smartRate->estimateDeliveryDate([
    'from_zip' => '10001',
    'to_zip' => '10002',
    'planned_ship_date' => '2024-07-18',
    'carriers' => ['UPS'],
]);

echo $results;
