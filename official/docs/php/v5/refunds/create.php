<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$shipment = \EasyPost\Shipment::retrieve('shp_...');

$shipment->refund();

echo $shipment;
