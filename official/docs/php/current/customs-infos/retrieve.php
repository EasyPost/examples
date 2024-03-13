<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$customsInfo = $client->customsInfo->retrieve('cstinfo_...');

echo $customsInfo;
