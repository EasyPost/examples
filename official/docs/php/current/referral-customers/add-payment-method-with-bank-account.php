<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$paymentMethod = $client->betaReferralCustomer->addPaymentMethod([
    'cus_...',
    'ba_...',
    'primary'
]);

echo $paymentMethod;
