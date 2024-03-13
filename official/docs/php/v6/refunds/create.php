<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$refunds = $client->refund->create([
    'carrier' => 'USPS',
    'tracking_codes' => ['EZ1000000001'],
]);

echo $refunds;
