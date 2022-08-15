<?php

\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$order = \EasyPost\Order::create([
    "to_address" => ["id" => "adr_..."],
    "from_address" => ["id" => "adr_..."],
    "shipments" => [
        [
            "parcel" => [
                "weight" => 10.2
            ]
        ],
        [
            "parcel" => [
                "predefined_package" => "FedExBox",
                "weight" => 17.5
            ]
        ],
    ],
]);

echo $order;
