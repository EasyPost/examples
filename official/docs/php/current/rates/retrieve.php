<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$rate = $client->rate->retrieve('rate...');

echo $rate;
