<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$carrier_account->credentials["pickup_id"] = "abc123";

$carrier_account->save();

echo $carrier_account;
