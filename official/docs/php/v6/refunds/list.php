<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$refunds = $client->refund->all([
    'page_size' => 5,
]);

echo $refunds;
