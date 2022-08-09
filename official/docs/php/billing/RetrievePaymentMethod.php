<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$payment_methods = Billing::retrieve_payment_methods();

echo $payment_methods;
