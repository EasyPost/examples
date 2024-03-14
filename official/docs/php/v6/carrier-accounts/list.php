<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$carrierAccounts = $client->carrierAccount->all();

echo $carrierAccounts;
