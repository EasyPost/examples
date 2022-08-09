<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$scan_form = \EasyPost\ScanForm::retrieve("sf_...");

echo $scan_form;
