<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$apiKey = $client->apiKeys->enable('ak_...');

echo $apiKey;
