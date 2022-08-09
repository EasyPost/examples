.php
<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$shipment = \EasyPost\Shipment::retrieve("shp_...");

echo $shipment;
