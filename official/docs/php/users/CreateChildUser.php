<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$child = \EasyPost\User::create(array(
    'name' => 'Child Account Name'
  ));

echo $child;
