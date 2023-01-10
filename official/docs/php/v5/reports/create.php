<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$report = \EasyPost\Report::create([
    'start_date' => '2022-10-01',
    'end_date' => '2022-10-31',
]);

echo $report;
