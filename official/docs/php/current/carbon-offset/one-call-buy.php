<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$toAddress = \EasyPost\Address::create(...);
$fromAddress = \EasyPost\Address::create(...);
$parcel = \EasyPost\Parcel::create(...);

// Reusing Easypost Objects

$shipment = \EasyPost\Shipment::create(
    [
        "carrier_accounts" => ["ca_..."],
        "service" => "NextDayAir",
        "to_address" => $toAddress,
        "from_address" => $from_address,
        "parcel" => $parcel
    ],
    null,
    true
);
