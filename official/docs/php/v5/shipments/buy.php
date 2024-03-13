<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$shipment = \EasyPost\Shipment::retrieve('shp_...');

$shipment->buy([
    'rate'      => $shipment->lowest_rate(),
    'insurance' => 249.99
]);

echo $shipment;
