<?php

\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$report = \EasyPost\Report::create([
    "start_date" => "2016-10-01",
    "end_date" => "2016-10-31",
]);

echo $report;
