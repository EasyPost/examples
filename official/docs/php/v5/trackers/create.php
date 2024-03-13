<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$tracker = \EasyPost\Tracker::create([
    'tracking_code' => 'EZ1000000001',
    'carrier' => 'USPS'
]);

echo $tracker;
