<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$shipment = \EasyPost\Shipment::retrieve('shp_...');

$shipment->buy([
    'rate'      => $shipment->lowest_rate(),
    'insurance' => null,
    'with_carbon_offset' => false,
    'end_shipper_id' => 'es_...'
]);

echo $shipment;
