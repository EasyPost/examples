<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$endshipper = $client->endShipper->retrieve('es_...');

echo $endshipper;
