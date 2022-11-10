shipment, err := client.CreateShipment(
  &easypost.Shipment{
    ToAddress: toAddress,
    FromAddress: fromAddress,
    Parcel: parcel,
  },
)
