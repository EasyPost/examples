shipment, err := client.CreateShipment(
  &easypost.Shipment{
    FromAddress: &easypost.Address{
      Company: "EasyPost",
      Street1: "417 Montgomery Street",
      Street2: "5th Floor",
      City:    "San Francisco",
      State:   "CA",
      Country: "US",
      Zip:     "94104",
    },
    ToAddress: &easypost.Address{
      Name:    "Tim Canterbury",
      Company: "Wernham Hogg",
      Street1: "118 Clippenham Lane",
      City:    "Slough",
      Country: "GB",
      Zip:     "SL15BE",
    },
    Parcel: &easypost.Parcel{
      Length: 9,
      Width:  6,
      Height: 3,
      Weight: 20,
    },
    CustomsInfo: &easypost.CustomsInfo{
      ...
    },
  },
)
