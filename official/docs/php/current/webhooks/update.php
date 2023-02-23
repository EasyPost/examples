<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$webhook = $client->webhook->retrieve('hook_...');

$updatedWebhook = $client->webhook->update();

echo $updatedWebhook;
