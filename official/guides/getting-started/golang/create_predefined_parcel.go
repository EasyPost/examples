parcel, err := client.CreateParcel(
  &easypost.Parcel{
    PredefinedPackage: "FlatRateEnvelope",
    Weight: 10,
  },
)
