<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$lumaShipment = $client->shipment->luma('shp_...', [
    'ruleset_name' => 'ruleset_name',
    'planned_ship_date' => 'YYYY-MM-DD',
    'deliver_by_date' => 'YYYY-MM-DD'
]);

echo $lumaShipment;
