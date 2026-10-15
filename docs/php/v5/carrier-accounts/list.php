<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$carrierAccounts = \EasyPost\CarrierAccount::all();

echo $carrierAccounts;
