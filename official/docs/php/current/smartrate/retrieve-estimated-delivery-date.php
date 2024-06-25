<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$estimatedDeliveryDates = $client->shipment->retrieveEstimatedDeliveryDate('shp_...', 'YYYY-MM-DD');

echo $estimatedDeliveryDates;
