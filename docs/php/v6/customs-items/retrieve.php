<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$customsItem = $client->customsItem->retrieve('cstitem_...');

echo $customsItem;
