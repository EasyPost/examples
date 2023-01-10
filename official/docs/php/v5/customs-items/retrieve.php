<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$customsItem = \EasyPost\CustomsItem::retrieve('cstitem_...');

echo $customsItem;
