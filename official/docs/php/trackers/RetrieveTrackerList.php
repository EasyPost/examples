<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$trackers = \EasyPost\Tracker::all(array(
    "page_size" => 5,
    "start_datetime" => "2016-01-02T08:50:00Z"
  ));

echo $trackers;
