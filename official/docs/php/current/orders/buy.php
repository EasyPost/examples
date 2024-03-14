<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$order = $client->order->retrieve('order_...');

$boughtOrder = $client->order->buy(
    $shipment->id,
    [
        'carrier' => 'FedEx',
        'service' => 'FEDEX_GROUND'
    ]
);

echo $boughtOrder;
