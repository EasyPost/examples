<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

$shipment = $client->shipment->retrieve('shp_...');

$formType = 'return_packing_slip';
$formOptions = [
    'barcode' => 'RMA12345678900',
    'line_items' => [
        [
            'product' => [
                'title' => 'Square Reader',
                'barcode' => '855658003251',
            ],
            'units' => 8,
        ],
    ],
];

$shipmentWithForm = $client->shipment->generateForm($shipment->id, $formType, $formOptions);

echo $shipmentWithForm;
