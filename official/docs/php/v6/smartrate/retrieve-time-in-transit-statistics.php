<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$shipment = $client->shipment->retrieve('shp_...');

$smartRates = $client->shipment->getSmartrates();

echo $smartRates;
