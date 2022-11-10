$shipment->buy($shipment->lowest_rate(array('USPS'), array('First')));

//OR

$shipment->buy(array('rate' => array('id' => '{RATE_ID}')))

// Print PNG link
print_r($shipment.postage_label.label_url);
// Print Tracking Code
print_r($shipment.postage_label.tracking_code);
