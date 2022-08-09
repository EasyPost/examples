<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$shipment = \EasyPost\Shipment::create(array(
    "to_address" => array(
        'name' => 'Dr. Steve Brule',
        'street1' => '179 N Harbor Dr',
        'city' => 'Redondo Beach',
        'state' => 'CA',
        'zip' => '90277',
        'country' => 'US',
        'phone' => '3331114444',
        'email' => 'dr_steve_brule@gmail.com'
    ),
    "from_address" => array(
        'name' => 'EasyPost',
        'street1' => '417 Montgomery Street',
        'street2' => '5th Floor',
        'city' => 'San Francisco',
        'state' => 'CA',
        'zip' => '94104',
        'country' => 'US',
        'phone' => '3331114444',
        'email' => 'support@easypost.com'
    ),
    "parcel" => array(
        "length" => 20.2,
        "width" => 10.9,
        "height" => 5,
        "weight" => 65.9
    ),
    "customs_info" => array('id' => "cstinfo_..."),
    "tax_identifiers" => array(array(
      "entity" => "SENDER",
      "tax_id" => "GB123456789",
      "tax_id_type" => "IOSS",
      "issuing_country" => "GB",
    ))
  ));

echo $shipment;
