<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$user = \EasyPost\User::retrieve_me();

$color = '#303F9F';

$brand = $user->update_brand([
    'color' => $color,
]);

echo $brand;
