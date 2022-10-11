<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$updatedUser = Referral::update_email('new_email@example.com', 'user_...');

echo $updatedUser;
