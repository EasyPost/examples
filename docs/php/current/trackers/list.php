<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$trackers = $client->tracker->all([
    'page_size' => 5,
]);

echo $trackers;
