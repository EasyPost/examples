<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$success = Billing::fund_wallet(2000, 'primary');

echo $success;
