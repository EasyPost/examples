<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$customs_item = \EasyPost\CustomsItem::retrieve("cstitem_...");

echo $customs_item;
