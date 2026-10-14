<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$shipment = $client->shipment->buy(
    'shp_...',
    [
        'rate'      => $shipment->lowestRate(),
        'insurance' => 249.99
    ]
);

echo $shipment;
