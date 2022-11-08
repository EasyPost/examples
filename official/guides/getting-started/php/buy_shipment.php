$shipment->buy($shipment->lowest_rate(array('USPS'), array('First')));

//OR

$shipment->buy(array('rate' => array('id' => '{RATE_ID}')))
