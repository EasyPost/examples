<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$client->referralCustomer->updateEmail('user_...', 'new_email@example.com');
