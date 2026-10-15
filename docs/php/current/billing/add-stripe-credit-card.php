<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$paymentMethod = $client->referralCustomer->addCreditCardFromStripe(
    'REFERRAL_USER_API_KEY',
    'seti_...',
    'primary',
);

echo $paymentMethod;
