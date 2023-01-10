<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$shipment = $client->shipment->retrieve('shp_...');

$boughtShipment = $client->$shipment->buy(
    $shipment->id,
    [
        'rate'      => $shipment->lowestRate(),
        'insurance' => 249.99
    ],
    true
);

echo $boughtShipment;
