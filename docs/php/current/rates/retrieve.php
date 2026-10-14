<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$rate = $client->rate->retrieve('rate...');

echo $rate;
