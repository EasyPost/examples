<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$retrievedShipment = $client->shipment->retrieve('shp_...');

$shipment = $client->shipment->buy(
    $retrievedShipment->id,
    [
        'rate'      => $retrievedShipment->lowestRate(),
        'insurance' => null,
        'with_carbon_offset' => false,
        'end_shipper_id' => 'es_...'
    ]
);

echo $shipment;
