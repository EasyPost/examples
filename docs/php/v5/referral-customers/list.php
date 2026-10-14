<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$referralUsers = Referral::all([
    'page_size' => 5,
]);

echo $referralUsers;
