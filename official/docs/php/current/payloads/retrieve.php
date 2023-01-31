<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$payload = $client->event->retrievePayload('evt_...', 'payload_...');

echo $payload;
