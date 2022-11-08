using EasyPost;
EasyPost.ClientManager.SetCurrent("<YOUR_TEST/PRODUCTION_API_KEY>");

Dictionary<string, object> toAddressData = new Dictionary<string, object>() {
  { "name", "George Costanza" },
  { "company", "Vandelay Industries" },
  { "street1", "1 E 161st St." },
  { "city", "Bronx" },
  { "state", "NY" },
  { "zip", "10451" }
};
Dictionary<string, object> fromAddressData = new Dictionary<string, object>() {
  { "company", "EasyPost" },
  { "street1", "417 Montgomery Street" },
  { "street2", "5th Floor" },
  { "city", "San Francisco" },
  { "state", "CA" },
  { "phone", "415-528-7555" },
  { "zip", "94104" }
};

Shipment shipment = await Shipment.Create(new Dictionary<string, object>() {
  { "parcel", new Dictionary<string, object>() {
    { "length", 9 },
    { "width", 6 },
    { "height", 2 },
    { "weight", 10 }
  } },
  { "to_address", toAddressData },
  { "from_address", fromAddressData }
});

await shipment.Buy(shipment.LowestRate());
