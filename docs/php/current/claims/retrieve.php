<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$claim = $client->claim->retrieve('clm_...');

echo $claim;
