<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$webhooks = $client->webhook->all();

echo $webhooks;
