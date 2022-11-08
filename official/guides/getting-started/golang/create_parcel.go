parcel, err := client.CreateParcel(
  &easypost.Parcel{
    Length: 9,
    Width:  6,
    Height: 2,
    Weight: 10,
  },
)
