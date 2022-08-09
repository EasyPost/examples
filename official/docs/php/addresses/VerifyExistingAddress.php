<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$address_params = array(
    "street1" => "417 montgomery streat",
    "street2" => "FL 5",
    "city"    => "San Francisco",
    "state"   => "CA",
    "zip"     => "94104",
    "country" => "US",
    "company" => "EasyPost",
    "phone"   => "415-123-4567"
);

$address = \EasyPost\Address::create($address_params);

$address->verify();

echo $addressses;
