<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$webhook = $client->webhook->create(['url' => 'example.com']);

echo $webhook;
