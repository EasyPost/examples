<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$paymentMethod = $client->referralCustomer->addBankAccountFromStripe(
    'REFERRAL_USER_API_KEY',
    'fca_...',
    [
        'ip_address' => '127.0.0.1',
        'user_agent' => 'Mozilla/5.0',
        'accepted_at' => 172251073,
    ],
    'primary',
);

echo $paymentMethod;
