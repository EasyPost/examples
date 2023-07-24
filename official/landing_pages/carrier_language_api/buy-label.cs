Address toAddress = await Address.Create(...);
Address fromAddress = await Address.Create(...);
Parcel parcel = await Parcel.Create(new Dictionary<string, object>() {
  { "predefined_package", "Parcel" },
  { "weight", 28 }
});

Shipment shipment = await Shipment.Create(new Dictionary<string, object>() {
  { "to_address", toAddress },
  { "from_address", fromAddress },
  { "parcel", parcel }
});

await shipment.Buy(shipment.LowestRate());
