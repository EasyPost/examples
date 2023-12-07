<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$carrierTypes = $client->carrierAccount->types();

echo $carrierTypes;
