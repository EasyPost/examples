<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$refund = $client->betaReferralCustomer->refundByPaymentLog('paylog_...');

echo $refund;
