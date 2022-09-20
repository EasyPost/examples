<?php

\EasyPost\EasyPost::setApiKey($_ENV['EASYPOST_API_KEY']);

$endshipper = \EasyPost\EndShipper::retrieve("es_...");

$endshipper->name = 'NEW NAME';
$endshipper->company = 'BAZ';
$endshipper->street1 = '164 TOWNSEND STREET UNIT 1';
$endshipper->street2 = 'UNIT 1';
$endshipper->city = 'SAN FRANCISCO';
$endshipper->state = 'CA';
$endshipper->zip = '94107';
$endshipper->country = 'US';
$endshipper->phone = '555-555-5555';
$endshipper->email = 'FOO@EXAMPLE.COM';

$endShipper->save();

echo $endShipper;
