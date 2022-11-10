toAddress, err := client.CreateAddress(
  &easypost.Address{
    Name:   "George Costanza",
    Company: "Vandelay Industries",
    Street1: "1 E 161st St",
    City: "Bronx",
    State: "NY",
    Zip: "10451",
  },
  &easypost.CreateAddressOptions{}
)
