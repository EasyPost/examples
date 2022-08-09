<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$shipment = \EasyPost\Shipment::create(array(
    "carrier_accounts" => 'ca_...', 
    "service" => 'NextDayAir',
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
    )
  ));

echo $shipment;
