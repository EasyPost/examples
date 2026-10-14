<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$response = $client->betaReferralCustomer->retrieveEasypostStripeApiKey();

echo $response;
