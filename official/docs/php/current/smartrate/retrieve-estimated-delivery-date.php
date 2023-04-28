<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$shipment = $client->shipment->retrieve('shp_...');

$estimatedDeliveryDates = $client->shipment->retrieveEstimatedDeliveryDate($shipment->id, "YYYY-MM-DD");

echo $estimatedDeliveryDates;
