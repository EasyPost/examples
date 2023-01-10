<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$address = $client->address->retrieve('adr_...');

echo $address;
