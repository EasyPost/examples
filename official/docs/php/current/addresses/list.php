<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$addresses = \EasyPost\Address::all([
    'page_size' => 5
]);

echo $addresses;
