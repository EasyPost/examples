<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$user = $client->user->retrieveMe();

$brand = $client->user->updateBrand(
    $user->id,
    ['color' => '#303F9F']
);

echo $brand;
