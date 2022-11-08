Dictionary<string, object> shipmentData = new Dictionary<string, object>() {
  {"to_address", toAddress},
  {"from_address", fromAddress},
  {"parcel", parcel}
}

Shipment shipment = await Shipment.Create(shipmentData);
