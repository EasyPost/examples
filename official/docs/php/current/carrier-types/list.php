<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$carrierTypes = \EasyPost\CarrierAccount::types();

echo $carrierTypes;
