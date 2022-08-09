<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$create_params = array("url" => "example.com");

$webhook = \EasyPost\Webhook::create($create_params);

echo $webhook;
