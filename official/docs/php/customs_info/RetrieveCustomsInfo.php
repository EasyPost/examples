<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$customs_info = \EasyPost\CustomsInfo::retrieve("cstinfo_...");

echo $customs_info;
