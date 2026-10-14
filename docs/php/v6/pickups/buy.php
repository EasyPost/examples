<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$pickup = $client->pickup->retrieve('pickup_...');

$boughtPickup = $client->pickup->buy(
    $pickup->id,
    [
        'carrier' => 'UPS',
        'service' => 'Same-day Pickup'
    ]
);

echo $pickup;
