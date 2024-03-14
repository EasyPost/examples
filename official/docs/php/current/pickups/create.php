<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$pickup = $client->pickup->create([
    'address' => ['id' => 'adr_...'],
    'shipment' => ['id' => 'shp_...'],
    'reference' => 'my-first-pickup',
    'min_datetime' => date('2022-10-01 10:30:00'),
    'max_datetime' => date('2022-10-02 10:30:00'),
    'is_account_address' => false,
    'instructions' => 'Special pickup instructions'
]);

echo $pickup;
