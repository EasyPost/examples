<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$carrierAccount = \EasyPost\CarrierAccount::retrieve('ca_...');

$carrierAccount->description = 'FL Location DHL eCommerce Solutions Account';
$carrierAccount->credentials = ['pickup_id' => 'abc123'];

$carrierAccount->save();

echo $carrierAccount;
