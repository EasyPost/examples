<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$addresses = \EasyPost\Address::all(array(
    "page_size" => 5
  ));
