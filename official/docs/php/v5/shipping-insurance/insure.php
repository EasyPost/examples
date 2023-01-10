<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$shipment = \EasyPost\Shipment::retrieve('shp_...');

$shipment->insure(['amount' => 100]);

echo $shipment;
