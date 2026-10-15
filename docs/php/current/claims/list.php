<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$claims = $client->claim->all([
    'page_size' => 5,
]);

echo $claims;
