<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$webhooks = $client->webhook->all();

echo $webhooks;
