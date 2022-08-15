<?php

\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$purchasedShipment = \EasyPost\Shipment::retrieve("shp_...");

$purchasedShipment->insure(['amount' => 100]);

echo $shipment;
