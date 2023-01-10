<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$user = \EasyPost\User::retrieve_me();

$brand = $user->update_brand([
    'color' => '#303F9F',
]);

echo $brand;
