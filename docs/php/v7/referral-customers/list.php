<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$referralUsers = $client->referralCustomer->all([
    'page_size' => 5,
]);

echo $referralUsers;
