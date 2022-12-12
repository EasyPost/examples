<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$referralUserApiKey = $_ENV['REFERRAL_USER_PROD_API_KEY'];

$creditCard = Referral::addCreditCard(
    $referralUserApiKey,
    '0123456789101234',
    '01',
    '2025',
    '111'
);

echo $creditCard;
