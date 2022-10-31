<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$paymentMethods = \EasyPost\Billing::retrieve_payment_methods();

echo $paymentMethods;
