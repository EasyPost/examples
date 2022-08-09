<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$shipment = \EasyPost\Shipment::create(array(
    "to_address" => array('id' => "adr_..."),
    "from_address" => array('id' => "adr_..."),
    "parcel" => array(
        "length" => 20.2,
        "width" => 10.9,
        "height" => 5,
        "weight" => 65.9
    ),
    "options" => array('address_validation_level' => 0)
  ));

  echo $shipment;
