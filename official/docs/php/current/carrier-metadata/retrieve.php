<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

// Request all metadata for all carriers
$carrierMetadata = $client->carrierMetadata->retrieveCarrierMetadata();
echo $carrierMetadata;

// Request specific metadata for specific carriers
$carrierMetadata = $client->carrierMetadata->retrieveCarrierMetadata(
    ['usps'],
    ['service_levels', 'predefined_packages'],
);
echo $carrierMetadata;
