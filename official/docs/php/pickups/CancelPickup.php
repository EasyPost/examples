<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$pickup = \EasyPost\Pickup::retrieve("pickup_...");

$pickup->cancel();

echo $pickup;
