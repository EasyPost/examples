<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

// When the `errors` key is returned as an array of FieldError objects
try {
    // Simulate a request with missing parameters
    $client->shipment->create([]);
} catch (\EasyPost\Exception\Api\ApiException $error) {
    echo $error->errors[0]['message'];
}

// When the `errors` key is returned as an array of strings
try {
    $claimParameters = [
        'tracking_code' => '123', // Simulate a request with an invalid tracking code
    ];
    $client->claim->create($claimParameters);
} catch (\EasyPost\Exception\Api\ApiException $error) {
    echo $error->errors[0];
}
