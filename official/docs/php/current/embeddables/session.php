<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$session = $client->embeddable->createSession([
    'origin_host' => 'https://example.com',
    'user_id' => 'user_...',
]);

echo $session;
