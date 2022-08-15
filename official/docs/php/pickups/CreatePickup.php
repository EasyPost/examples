<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$pickup = \EasyPost\Pickup::create([
    'address' => ['id' => 'adr_...'],
    'shipment' => ['id' => 'shp_...'],
    'reference' => 'my-first-pickup',
    'min_datetime' => date('2014-10-20 17:10:00'),
    'max_datetime' => date('2014-10-21 10:30:00'),
    'is_account_address' => false,
    'instructions' => 'Special pickup instructions'
]);

echo $pickup;
