<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$payloads = $client->event->retrieveAllPayloads('evt_...');

echo $payloads;
