<?php

\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$report = \EasyPost\Report::retrieve('<REPORT_ID>');

echo $report;
