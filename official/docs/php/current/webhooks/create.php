<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$webhook = \EasyPost\Webhook::create(['url' => 'example.com']);

echo $webhook;
