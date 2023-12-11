<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$shipment = $client->shipment->retrieve('shp_...');

$boughtShipment = $client->shipment->buy(
    $shipment->id,
    [
        'rate'      => $shipment->lowestRate(),
        'insurance' => null,
        'with_carbon_offset' => false,
        'end_shipper_id' => 'es_...'
    ]
);

echo $boughtShipment;
