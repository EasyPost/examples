<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$shipment = \EasyPost\Shipment::retrieve('shp_...');

$shipment->refund();

echo $shipment;
