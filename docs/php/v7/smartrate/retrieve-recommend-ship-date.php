<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$rates = $client->shipment->recommendShipDate('shp_...', 'YYYY-MM-DD');

echo $rates;
