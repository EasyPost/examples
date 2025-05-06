<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$shipment = $client->shipment->label(
    'shp_...',
    ['file_format' => 'ZPL']
);

echo $shipment;
