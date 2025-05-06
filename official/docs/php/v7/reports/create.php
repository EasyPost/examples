<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$report = $client->report->create([
    'type' => 'payment_log',
    'start_date' => '2022-10-01',
    'end_date' => '2022-10-31',
]);

echo $report;
