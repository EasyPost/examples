<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$creditCard = Referral::addCreditCard(
    'REFERRAL_PROD_API_KEY',
    '0123456789101234',
    '01',
    '2025',
    '111'
);

echo $creditCard;
