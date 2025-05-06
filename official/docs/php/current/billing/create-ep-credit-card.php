<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$creditCard = $client->referralCustomer->addCreditCard(
    'REFERRAL_USER_API_KEY',
    '0123456789101234',
    '01',
    '2025',
    '111'
);

echo $creditCard;
