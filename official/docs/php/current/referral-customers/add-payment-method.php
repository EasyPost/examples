<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$paymentMethod = $client->betaReferralCustomer->addPaymentMethod([
    'cus_123',
    'ba_123',
    'primary'
]);

echo $paymentMethod;
