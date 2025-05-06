<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$address = $client->address->create([
    'verify_strict'  => true,
    'street1' => '000 unknown street',
    'city'    => 'Not a City',
    'state'   => 'ZZ',
    'zip'     => '00001',
    'country' => 'US',
    'email' => 'test@example.com',
    'phone'   => '5555555555',
]);

echo $address;
