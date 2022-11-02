<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$carrierAccounts = \EasyPost\CarrierAccount::all();

echo $carrierAccounts;
