<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$shipment = \EasyPost\Shipment::retrieve("shp_...");

$shipment->buy(array(
  'rate'      => "rate_...",
  'insurance' => 249.99
));

echo $shipment;
