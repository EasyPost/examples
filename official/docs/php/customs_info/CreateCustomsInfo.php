<?php

\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$customsItem = \EasyPost\CustomsItem::create(...);

$customsInfo = \EasyPost\CustomsInfo::create([
    "eel_pfc" => 'NOEEI 30.37(a)',
    "customs_certify" => true,
    "customs_signer" => 'Steve Brule',
    "contents_type" => 'merchandise',
    "contents_explanation" => '',
    "restriction_type" => 'none',
    "customs_items" => [$customsItem, [
        "description" => 'T-shirt',
        "quantity" => 1,
        "weight" => 5,
        "value" => 10,
        "hs_tariff_number" => '123456',
        "origin_country" => 'US'
    ]]
]);

echo $customsInfo;
