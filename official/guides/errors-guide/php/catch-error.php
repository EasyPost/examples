<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

try {
    $client->address->create(["strict_verify" => true]);
} catch (\EasyPost\Exception\Api\ApiException $error) {
    echo $error->code;
}
