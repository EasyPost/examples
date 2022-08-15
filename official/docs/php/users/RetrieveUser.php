<?php

\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$childUser = \EasyPost\User::retrieve("user_...");

echo $childUser;
