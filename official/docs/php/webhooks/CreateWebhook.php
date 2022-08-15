<?php

\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$createParams = ["url" => "example.com"];

$webhook = \EasyPost\Webhook::create($createParams);

echo $webhook;
