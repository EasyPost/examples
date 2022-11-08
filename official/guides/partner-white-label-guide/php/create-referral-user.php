<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$referralUser = Referral::create([
  'name' => 'Test Referral',
  'email' => 'test@test.com',
  'phone' => '8888888888'
]);

echo $referralUser;
