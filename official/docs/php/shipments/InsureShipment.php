<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$purchased_shipment = \EasyPost\Shipment::retrieve("shp_...");

$purchased_shipment->insure(array('amount' => 100));

echo $shipment;
