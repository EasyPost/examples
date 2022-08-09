<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$customs_item = \EasyPost\CustomsItem::create(array(
    "description" => 'T-shirt',
    "quantity" => 1,
    "weight" => 5,
    "value" => 10,
    "hs_tariff_number" => '123456',
    "origin_country" => 'US'
  ));

echo $customs_item;
