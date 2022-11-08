<?php

\EasyPost\EasyPost::setApiKey("<YOUR_PRODUCTION_API_KEY>");

$me = \EasyPost\User::retrieve_me();
$me->recharge_threshold = "50.00";
$me->save();
