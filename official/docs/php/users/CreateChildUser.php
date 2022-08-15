<?php

\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$child = \EasyPost\User::create([
    'name' => 'Child Account Name'
]);

echo $child;
