<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$events = \EasyPost\Event::all(array(
    "page_size" => 5
  ));

echo $events;
