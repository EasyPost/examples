<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$webhook = $client->webhook->create(['url' => 'example.com']);

echo $webhook;
