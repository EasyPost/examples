<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$customsItem = \EasyPost\CustomsItem::retrieve('cstitem_...');

echo $customsItem;
