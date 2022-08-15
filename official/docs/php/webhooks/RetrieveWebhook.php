<?php

\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$webhook = \EasyPost\Webhook::retrieve("hook_...");

echo $webhook;
