<?php

$client = new \EasyPost\EasyPostClient('EASYPOST_API_KEY');

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

$shipmentWithForm = $client->shipment->generateForm('shp_...', $formType, $formOptions);

echo $shipmentWithForm;
