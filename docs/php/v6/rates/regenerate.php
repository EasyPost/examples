<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$shipment = $client->shipment->retrieve('shp_...');

$shipmentWithRegeneratedrates = $client->shipment->regenerateRates($shipment->id);

echo $shipmentWithRegeneratedrates;
