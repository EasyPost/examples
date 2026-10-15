<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$addresses = $client->address->all([
    'page_size' => 5
]);

echo $addresses;
