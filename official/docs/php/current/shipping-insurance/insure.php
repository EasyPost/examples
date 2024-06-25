<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$shipment = $client->shipment->insure(
    'shp_...',
    ['amount' => 100]
);

echo $shipment;
