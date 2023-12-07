<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$report = $client->report->retrieve('<REPORT_ID>');

echo $report;
