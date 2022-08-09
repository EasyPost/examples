<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$pickup = \EasyPost\Pickup::retrieve("my-id");

$pickup->buy(array(
    'carrier'=>'UPS',
    'service' => 'Same-day Pickup'
 ));

echo $pickup;
