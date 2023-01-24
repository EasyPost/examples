<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$paymentMethod = $client->betaReferralCustomer->addPaymentMethod([
    'cus_...',
    'card_...',
    'primary'
]);

echo $paymentMethod;
