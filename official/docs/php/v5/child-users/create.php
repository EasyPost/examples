<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$child = \EasyPost\User::create([
    'name' => 'Child Account Name'
]);

echo $child;
