<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$user = \EasyPost\User::retrieve_me();

$user->recharge_threshold = '50.00';

$user->save();

echo $user;
