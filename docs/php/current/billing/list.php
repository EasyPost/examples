<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$paymentMethods = $client->billing->retrievePaymentMethods();

echo $paymentMethods;
