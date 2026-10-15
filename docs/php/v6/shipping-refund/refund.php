<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$shipment = $client->shipment->retrieve('shp_...');

$refundedShipment = $client->shipment->refund($shipment->id);

echo $refundedShipment;
