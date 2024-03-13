<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$carrierTypes = \EasyPost\CarrierAccount::types();

echo $carrierTypes;
