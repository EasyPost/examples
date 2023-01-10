<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$insurances = $client->insurance->all([
    'page_size' => 5,
]);

echo $insurances;
