<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$order = \EasyPost\Order::create(array(
    "carrier_accounts" => 'ca_...', 
    "service" => 'NextDayAir',
    "to_address" =>array("id" => "adr_..."),
    "from_address" => array("id" => "adr_..."),
    "shipments" => array(
        array(
            "parcel" => array(
                "weight" => 10.2
            )
        ),
        array(
            "parcel" => array(
                "predefined_package" => "FedExBox",
                "weight" => 17.5
            )
        ),
    ),
));

echo $order;
