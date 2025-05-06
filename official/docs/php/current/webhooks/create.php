<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$webhook = $client->webhook->create([
    'url' => 'example.com',
    'webhook_secret' => 'A1B2C3',
    'custom_headers' => [
        'X-Header-Name' => 'header_value',
    ],
]);

echo $webhook;
