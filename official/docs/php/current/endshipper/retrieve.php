<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$endshipper = $client->endShipper->retrieve('es_...');

echo $endshipper;
