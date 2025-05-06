<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$smartRates = $client->shipment->getSmartrates('shp_...');

echo $smartRates;
