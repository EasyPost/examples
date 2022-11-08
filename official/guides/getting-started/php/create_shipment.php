$shipment = \EasyPost\Shipment::create(array(
  "to_address" => $toAddress,
  "from_address" => $fromAddress,
  "parcel" => $parcel
));
