<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$success = \EasyPost\Billing::delete_payment_method('primary');

echo $success;
