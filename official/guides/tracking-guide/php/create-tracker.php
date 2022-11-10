## Creating a Tracker
$tracking_code = "EZ4000000004";
$carrier = "UPS";
$tracker = \EasyPost\Tracker::create(array('tracking_code' => $tracking_code, 'carrier' => $carrier));
