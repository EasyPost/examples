<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$addressParams = [
    'verify'  => true,
    'street1' => '417 Montgomery Streat',
    'street2' => '5',
    'city'    => 'SF',
    'state'   => 'CA',
    'zip'     => '94104',
    'country' => 'US',
    'company' => 'EasyPost',
    'phone'   => '415-123-4567'
];

$address = \EasyPost\Address::create($addressParams);

echo $address;
