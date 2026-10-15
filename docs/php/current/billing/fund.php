<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$client->billing->fundWallet(2000, 'primary');
