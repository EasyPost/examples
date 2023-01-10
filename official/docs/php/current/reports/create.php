<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$report = $client->report->create([
    'start_date' => '2022-10-01',
    'end_date' => '2022-10-31',
]);

echo $report;
