<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$reports = $client->report->all([
    // Replace `payment_log` with any of the report types listed above
    'type' => 'payment_log',
    'page_size' => 5,
]);

echo $reports;
