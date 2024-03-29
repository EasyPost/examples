<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$shipment = $client->shipment->retrieve('shp_...');

$shipmentWithInsurance = $client->shipment->insure(
    $shipment->id,
    ['amount' => 100]
);

echo $shipmentWithInsurance;
