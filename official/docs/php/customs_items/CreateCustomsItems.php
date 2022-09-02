<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$customsItem = \EasyPost\CustomsItem::create([
    'description' => 'T-shirt',
    'quantity' => 1,
    'weight' => 5,
    'value' => 10,
    'hs_tariff_number' => '123456',
    'origin_country' => 'US'
]);

echo $customsItem;
