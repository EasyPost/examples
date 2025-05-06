<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$carrierTypes = $client->carrierAccount->types();

echo $carrierTypes;
