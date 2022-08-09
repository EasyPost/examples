<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$webhooks = \EasyPost\Webhook::all();

echo $webhooks;
