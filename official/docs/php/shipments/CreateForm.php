<?php

\EasyPost\EasyPost::setApiKey('EASYPOST_API_KEY');

$shipment = \EasyPost\Shipment::retrieve('shp_...');
$shipment->buy();

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

$shipment->generate_form($formType, $formOptions);

echo $shipment;
