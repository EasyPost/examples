<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$tracker = \EasyPost\Tracker::create([
    'tracking_code' => 'EZ1000000001',
    'carrier' => 'USPS'
]);

echo $tracker;
