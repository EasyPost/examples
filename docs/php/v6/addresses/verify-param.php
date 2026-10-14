<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$address = $client->address->create([
    'verify'  => true,
    'street1' => '417 Montgomery Streat',
    'street2' => '5',
    'city'    => 'SF',
    'state'   => 'CA',
    'zip'     => '94104',
    'country' => 'US',
    'company' => 'EasyPost',
    'phone'   => '415-123-4567'
]);

echo $address;
