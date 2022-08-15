<?php

\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$addresses = \EasyPost\Address::all([
    "page_size" => 5
]);

echo $addressses;
