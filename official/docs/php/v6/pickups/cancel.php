<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$pickup = $client->pickup->retrieve('pickup_...');

$cancelledPickup = $client->pickup->cancel($pickup->id);

echo $cancelledPickup;
