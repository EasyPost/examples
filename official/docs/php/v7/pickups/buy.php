<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$pickup = $client->pickup->buy(
    'pickup_...',
    [
        'carrier' => 'UPS',
        'service' => 'Same-day Pickup'
    ]
);

echo $pickup;
