<?php

$client = new \EasyPost\EasyPostClient(getenv('EASYPOST_API_KEY'));

$shipment = $client->shipment->create([
    'to_address' => $to_address,
    'from_address' => $from_address,
    'parcel' => [
        'predefined_package' => 'Parcel',
        'weight' => 28
    ]
]);

$client->shipment->buy(
    $shipment->id,
    ['rate' => $shipment->lowest_rate()]
);
