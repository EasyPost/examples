<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$webhook = $client->webhook->create([
    'url' => 'example.com',
    "webhook_secret" => "A1B2C3",
]);

echo $webhook;
