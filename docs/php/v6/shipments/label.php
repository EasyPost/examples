<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$shipment = $client->shipment->retrieve('shp_...');

$shipmentWithLabel = $client->shipment->label(
    $shipment->id,
    ['file_format' => 'ZPL']
);

echo $shipment;
