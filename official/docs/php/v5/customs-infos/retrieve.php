<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$customsInfo = \EasyPost\CustomsInfo::retrieve('cstinfo_...');

echo $customsInfo;
