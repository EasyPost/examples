<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$carrier_account = \EasyPost\CarrierAccount::retrieve("ca_...");

$carrier_account->delete();

echo $carrier_account;
