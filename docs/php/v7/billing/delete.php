<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$client->billing->deletePaymentMethod('primary');
