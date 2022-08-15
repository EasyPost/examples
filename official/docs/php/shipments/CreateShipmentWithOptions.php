<?php

\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$shipment = \EasyPost\Shipment::create([
    "to_address" => ['id' => "adr_..."],
    "from_address" => ['id' => "adr_..."],
    "parcel" => [
        "length" => 20.2,
        "width" => 10.9,
        "height" => 5,
        "weight" => 65.9
    ],
    "options" => ['address_validation_level' => 0]
]);

echo $shipment;
