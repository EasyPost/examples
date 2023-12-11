<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$client->billing->deletePaymentMethod('primary');
