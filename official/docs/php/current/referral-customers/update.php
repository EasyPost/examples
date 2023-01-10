<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$client->referralCustomer->updateEmail('new_email@example.com', 'user_...');
