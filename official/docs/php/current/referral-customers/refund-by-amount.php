<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$refund = $client->betaReferralCustomer->refundByAmount(2000);

echo $refund;
