<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$webhook = \EasyPost\Webhook::retrieve('hook_...');

echo $webhook;
