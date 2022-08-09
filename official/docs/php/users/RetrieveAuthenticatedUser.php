<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$user = \EasyPost\User::retrieve_me();

echo $user;
