<?php

\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$customsInfo = \EasyPost\CustomsInfo::retrieve("cstinfo_...");

echo $customsInfo;
