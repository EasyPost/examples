<?php

$to_address = \\EasyPost\\Address::create(...)
$from_address = \\EasyPost\\Address::create(...)
$parcel = \\EasyPost\\Parcel::create(array(
  'predefined_package' => 'Parcel'
  'weight' => 28
));

$shipment = \\EasyPost\\Shipment::create(array(
  'to_address' => $to_address
  'from_address' => $from_address,
  'parcel' => $parcel
));

$shipment->buy(array('rate' => $shipment->lowest_rate()));
