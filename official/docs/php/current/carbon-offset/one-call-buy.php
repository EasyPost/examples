<?php

require_once("path/to/lib/easypost.php");

\EasyPost\EasyPost::setApiKey("<YOUR_TEST/PRODUCTION_API_KEY>");

$to_address = \EasyPost\Address::create(...);
$from_address = \EasyPost\Address::create(...);
$parcel = \EasyPost\Parcel::create(...);

// Reusing Easypost Objects

$shipment = \EasyPost\Shipment::create(array(
    "carrier_accounts" => [“ca_...”], 
    "service" => “NextDayAir”,
    "to_address" => $to_address,
    "from_address" => $from_address,
    "parcel" => $parcel
    ),
    null,
    true
);
