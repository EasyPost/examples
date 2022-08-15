<?php

\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$success = \EasyPost\Billing::fund_wallet(2000, 'primary');

echo $success;
