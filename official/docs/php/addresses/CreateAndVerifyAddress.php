<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$addressParams = [
    'street1' => '417 Montgomery Street',
    'street2' => 'FL 5',
    'city'    => 'San Francisco',
    'state'   => 'CA',
    'zip'     => '94104',
    'country' => 'US',
    'company' => 'EasyPost',
    'phone'   => '415-123-4567'
];

$address = \EasyPost\Address::create_and_verify($addressParams);

echo $address;
