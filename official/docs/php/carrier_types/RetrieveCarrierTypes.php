<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$carrier_types = \EasyPost\CarrierAccount::types();

echo $carrier_types;
