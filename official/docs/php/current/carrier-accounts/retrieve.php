<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$carrierAccount = \EasyPost\CarrierAccount::retrieve('ca_...');

echo $carrierAccount;
