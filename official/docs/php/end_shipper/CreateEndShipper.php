<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$endshipper_params = array(
    "name" => "FOO BAR",
    "company" => "BAZ",
    "street1" => "164 TOWNSEND STREET UNIT 1",
    "street2" => "UNIT 1",
    "city" => "SAN FRANCISCO",
    "state" => "CA",
    "zip" => "94107",
    "country" => "US",
    "phone" => "555-555-5555",
    "email" => "FOO@EXAMPLE.COM"
);

$endshipper = \EasyPost\EndShipper::create($endshipper_params);

echo $endshipper;
