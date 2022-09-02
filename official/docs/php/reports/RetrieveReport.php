<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$report = \EasyPost\Report::retrieve('<REPORT_ID>');

echo $report;
