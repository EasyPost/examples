<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$apiKey = $client->apiKeys->disable('ak_...');

echo $apiKey;
