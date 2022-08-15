<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$order = \EasyPost\Order::retrieve('order_...');

$order->buy([
    'carrier' => 'FedEx',
    'service' => 'FEDEX_GROUND'
]);

echo $order;
