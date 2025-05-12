<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$results = $client->smartRate->recommendShipDate([
    'from_zip' => '10001',
    'to_zip' => '10002',
    'desired_delivery_date' => '2024-07-18',
    'carriers' => ['UPS'],
]);

echo $results;
