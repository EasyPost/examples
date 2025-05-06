<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$pickups = $client->pickup->all([
    'page_size' => 5,
]);

echo $pickups;
