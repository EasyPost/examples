<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$address = $client->address->verify('adr_...');

echo $address;
