<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$pickup = \EasyPost\Pickup::retrieve('pickup_...');

$pickup->buy([
    'carrier' => 'UPS',
    'service' => 'Same-day Pickup'
]);

echo $pickup;
