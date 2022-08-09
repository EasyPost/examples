<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$tracker = \EasyPost\Tracker::create(array(
    "tracking_code" => "9400110898825022579493",
    "carrier" => "USPS"
  ));

echo $tracker;
