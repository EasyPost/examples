<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$retrieved_address = \EasyPost\Address::retrieve("adr_...");
