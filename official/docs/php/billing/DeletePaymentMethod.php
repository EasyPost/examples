<?php

\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$success = \EasyPost\Billing::delete_payment_method('primary');

echo $success;
