<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$scan_forms = \EasyPost\ScanForm::all(array("page_size" => 5));

echo $scan_forms;
