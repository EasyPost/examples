<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$shipment = \EasyPost\Shipment::retrieve('shp_...');
$shipment->label([
    'file_format' => 'ZPL'
]);

echo $shipment;
