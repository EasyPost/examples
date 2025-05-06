<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$pickup = $client->pickup->retrieve('pickup_...');

echo $pickup;
