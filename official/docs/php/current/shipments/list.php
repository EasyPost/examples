<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$shipments = $client->shipment->all([
    'page_size' => 5,
]);

echo $shipments;
