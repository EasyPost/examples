<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$payload = $client->event->retrievePayload('evt_...', 'payload_...');

echo $payload;
