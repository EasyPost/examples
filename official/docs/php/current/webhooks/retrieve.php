<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$webhook = $client->webhook->retrieve('hook_...');

echo $webhook;
