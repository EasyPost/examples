<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$client->referralCustomer->updateEmail('new_email@example.com', 'user_...');
