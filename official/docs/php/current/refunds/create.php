<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$refunds = $client->refund->create([
    'carrier' => 'USPS',
    'tracking_codes' => ['XXXXX'],
]);

echo $refunds;
