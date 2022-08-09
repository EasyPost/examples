<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$user = \EasyPost\User::retrieve_me();

$api_keys = $user->all_api_keys();

echo $api_keys;
