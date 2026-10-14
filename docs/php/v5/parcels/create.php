<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$parcel = \EasyPost\Parcel::create([
    'length' => 20.2,
    'width' => 10.9,
    'height' => 5,
    'weight' => 65.9
]);

echo $parcel;
