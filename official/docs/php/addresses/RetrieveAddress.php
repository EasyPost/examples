<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$address = \EasyPost\Address::retrieve('adr_...');

echo $address;
