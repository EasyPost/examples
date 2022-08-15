<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$paymentMethods = \EasyPost\Billing::retrieve_payment_methods();

echo $paymentMethods;
