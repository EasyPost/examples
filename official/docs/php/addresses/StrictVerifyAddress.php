<?php

require_once("../lib/easypost.php");
\EasyPost\EasyPost::setApiKey("EASYPOST_API_KEY");

try {
    $address_params = array(
        "verify_strict"  => true,
        "street1"        => "UNDELIEVRABLE ST",
        "street2"        => "FL 5",
        "city"           => "San Francisco",
        "state"          => "CA",
        "zip"            => "94104",
        "country"        => "US",
        "company"        => "EasyPost",
        "phone"          => "415-123-4567"
    );

    // this request will raise an error
    $address = \EasyPost\Address::create($address_params);
} catch (Exception $e) {
    echo "Status: " . $e->getHttpStatus() . ": ";
    echo $e->getMessage() . "\n";
    // Status: 400: Address not found

    exit();
}
