<?php

try {
    \EasyPost\Address::create([
        "strict_verify" => true,
    ]);
} catch (\EasyPost\Exception\Api\ApiException $error) {
    echo $error->code;
}
