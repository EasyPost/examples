<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$webhooks = \EasyPost\Webhook::all();

echo $webhooks;
