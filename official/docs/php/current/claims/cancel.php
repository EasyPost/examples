<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$claim = $client->claim->cancel('clm_...');

echo $claim;
