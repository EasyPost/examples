apiKey := os.Getenv("<YOUR_TEST/PRODUCTION_API_KEY>")
client := easypost.New(apiKey)

toAddress, err := client.CreateAddress(...)
fromAddress, err := client.CreateAddress(...)
parcel, err := client.CreateParcel(
  &easypost.Parcel(
    PredefinedPackage: "Parcel",
    Weight: 28,
  ),
)

shipment, err := client.CreateShipment(
  &easypost.Shipment(
    ToAddress: toAddress,
    FromAddress: fromAddress,
    Parcel: parcel,
  ),
)

shipment, err = client.BuyShipment(shipment.ID, shipment.Rates[0], "100.00")
