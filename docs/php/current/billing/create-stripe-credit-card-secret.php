<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$response = $client->betaReferralCustomer->createCreditCardClientSecret();

echo $response;
