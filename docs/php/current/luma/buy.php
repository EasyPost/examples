<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$shipment = $client->shipment->luma('shp_...', [
    'ruleset_name' => 'ruleset_...',
    'planned_ship_date' => '2025-07-18',
    'deliver_by_date' => '2025-07-20'
]);

echo $shipment;
