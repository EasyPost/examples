<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$payloads = $client->event->retrieveAllPayloads('evt_...');

echo $payloads;
