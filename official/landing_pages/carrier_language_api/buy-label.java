Address toAddress = Address.create(...);
Address fromAddress = Address.create(...);
Parcel parcel = Parcel.create(new HashMap<string, object>() { {
  put("predefined_package", "Parcel");
  put("weight", 28);
} });

Shipment shipment = Shipment.create(new HashMap<string, object>() { {
  put("to_address", toAddress);
  put("from_address", fromAddress);
  put("parcel", parcel);
} });

shipment.buy(shipment.lowestRate());
