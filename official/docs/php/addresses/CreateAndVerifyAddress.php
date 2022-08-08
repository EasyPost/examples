<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$address_params = array(
    "street1" => "417 Montgomery Street",
    "street2" => "FL 5",
    "city"    => "San Francisco",
    "state"   => "CA",
    "zip"     => "94104",
    "country" => "US",
    "company" => "EasyPost",
    "phone"   => "415-123-4567"
);

$verified_address = \EasyPost\Address::create_and_verify($address_params);
