<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$shipment = \EasyPost\Shipment::retrieve('shp_...');

$shipment->buy([
    'rate'      => 'rate_...',
    'insurance' => null,
    'with_carbon_offset' => false,
    'end_shipper_id' => 'es_...'
]);

echo $shipment;
