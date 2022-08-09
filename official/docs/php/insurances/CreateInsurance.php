<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$insurance = \EasyPost\Insurance::create(array(
    "to_address" => array("id" => "adr_..."),
    "from_address" => array("id" => "adr_..."),
    "tracking_code" => "9400110898825022579493",
    "carrier" => "USPS",
    "amount" => "100.00",
    "reference" => "insuranceRef1"
));

echo $insurance;
