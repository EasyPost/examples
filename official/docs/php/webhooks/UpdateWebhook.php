<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$webhook = \EasyPost\Webhook::retrieve("hook_...");

$webhook->update();

echo $webhook;
