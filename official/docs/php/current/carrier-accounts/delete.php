<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$carrierAccount = $client->carrierAccount->retrieve('ca_...');

$client->$carrierAccount->delete($carrierAccount->id);
