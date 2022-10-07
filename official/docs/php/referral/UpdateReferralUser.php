<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$referralUsers = Referral::all([
  'page_size' => 5,
]);

$updatedUser = Referral::update_email('email@example.com', $referralUsers[0]['id']);

echo $updatedUser;
