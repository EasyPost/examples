<?php

require_once("path/to/lib/easypost.php");

\EasyPost\EasyPost::setApiKey("<YOUR_TEST/PRODUCTION_API_KEY>");

$to_address = \EasyPost\Address::create(...);
$from_address = \EasyPost\Address::create(...);
$parcel = \EasyPost\Parcel::create(...);
$customs_info = \EasyPost\CustomsInfo::create(...);

$shipment = \EasyPost\Shipment::create(array(
    "to_address" => $to_address,
    "from_address" => $from_address,
    "parcel" => $parcel,
    "customs_info" => $customs_info
  ),
  null,
  true
);
