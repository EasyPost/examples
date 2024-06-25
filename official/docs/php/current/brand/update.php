<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$brand = $client->user->updateBrand(
    'user_...',
    ['color' => '#303F9F']
);

echo $brand;
