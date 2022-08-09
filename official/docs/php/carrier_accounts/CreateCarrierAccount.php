<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

$carrier_account = \EasyPost\CarrierAccount::create(array(
    'type' => 'DhlEcsAccount',
    'description' => 'CA Location DHL eCommerce Solutions Account',
    'credentials' => array(
      'client_id' => '123456',
      'client_secret' => '123abc',
      'distribution_center' => 'USLAX1',
      'pickup_id' => '123456'
    ),
    'test_credentials' => array(
      'client_id' => '123456',
      'client_secret' => '123abc',
      'distribution_center' => 'USLAX1',
      'pickup_id' => '123456'
    )
  ));

echo $carrier_account;
