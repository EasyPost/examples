<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$carrierAccounts = $client->carrierAccount->all();

echo $carrierAccounts;
