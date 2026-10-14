<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$trackers = $client->tracker->retrieveBatch([
    'tracking_codes' => ['EZ1000000001', 'EZ1000000002'],
]);

echo $trackers;
