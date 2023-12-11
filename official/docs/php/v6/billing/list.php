<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$paymentMethods = $client->billing->retrievePaymentMethods();

echo $paymentMethods;
