<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$apiKey = $client->apiKeys->create('test');

echo $apiKey;
