<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$shipments = \EasyPost\Shipment::all([
    'page_size' => 5,
]);

echo $shipments;
