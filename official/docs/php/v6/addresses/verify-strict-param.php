<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$address = $client->address->create([
    'verify_strict'  => true,
    'street1'        => '417 MONTGOMERY ST',
    'street2'        => 'FL 5',
    'city'           => 'San Francisco',
    'state'          => 'CA',
    'zip'            => '94104',
    'country'        => 'US',
    'company'        => 'EasyPost',
    'phone'          => '415-123-4567'
]);

echo $address;
