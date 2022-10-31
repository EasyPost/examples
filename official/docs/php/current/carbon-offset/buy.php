<?php

require_once("path/to/lib/easypost.php");

\EasyPost\EasyPost::setApiKey("<YOUR_TEST/PRODUCTION_API_KEY>");

$shipment = \EasyPost\Shipment::retrieve("shp_...");
$shipment->buy(array(
    'rate'      => $shipment->lowest_rate(),
    'insurance' => 249.99
    ),
    withCarbonOffset = true
);
