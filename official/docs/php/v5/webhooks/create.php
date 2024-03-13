<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$webhook = \EasyPost\Webhook::create(['url' => 'example.com']);

echo $webhook;
