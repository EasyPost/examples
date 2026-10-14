<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$address = $client->address->create([
    'street1' => 'UNDELIVERABLE ST',
    'city'    => 'San Francisco',
    'state'   => 'CA',
    'zip'     => '94104',
    'country' => 'US',
    'company' => 'EasyPost',
    'phone'   => '415-123-4567'
]);

echo $address;
