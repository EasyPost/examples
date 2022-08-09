<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$customs_item = \EasyPost\CustomsItem::create(...);

$customs_info = \EasyPost\CustomsInfo::create(array(
  "eel_pfc" => 'NOEEI 30.37(a)',
  "customs_certify" => true,
  "customs_signer" => 'Steve Brule',
  "contents_type" => 'merchandise',
  "contents_explanation" => '',
  "restriction_type" => 'none',
  "customs_items" => array($customs_item, array(
    "description" => 'T-shirt',
    "quantity" => 1,
    "weight" => 5,
    "value" => 10,
    "hs_tariff_number" => '123456',
    "origin_country" => 'US'
  ))
));

echo $customs_info;
