<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$customsItem = $client->customsItem->create([
    'description' => 'T-shirt',
    'quantity' => 1,
    'weight' => 5,
    'value' => 10,
    'hs_tariff_number' => '123456',
    'origin_country' => 'US'
]);

echo $customsItem;
