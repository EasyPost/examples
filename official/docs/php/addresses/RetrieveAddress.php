<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$address = \EasyPost\Address::retrieve('adr_...');

echo $address;
