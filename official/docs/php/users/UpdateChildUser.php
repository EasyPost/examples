<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$user = \EasyPost\User::retrieve('user_...');

$user->name = 'Test Child';

$user->save();

echo $user;
