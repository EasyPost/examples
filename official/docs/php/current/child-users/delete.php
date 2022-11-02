<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$user = \EasyPost\User::retrieve('user_...');

$user->delete();

echo $user;
