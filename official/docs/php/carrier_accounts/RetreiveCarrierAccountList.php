<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$carrier_accounts = \EasyPost\CarrierAccount::all();

echo $carrier_accounts;
