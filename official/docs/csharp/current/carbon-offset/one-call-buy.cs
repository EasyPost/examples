using EasyPost;
EasyPost.ClientManager.SetCurrent("<YOUR_TEST/PRODUCTION_API_KEY>");

Dictionary<string, object> fromAddress = new Dictionary<string, object>() {
  { "name", "Dr. Steve Brule" },
  { "street1", "417 Montgomery Street" },
  { "street2", "5th Floor" },
  { "city", "San Francisco" },
  { "state", "CA" },
  { "country", "US" },
  { "zip", "94104" }
};

Dictionary<string, object> toAddress = new Dictionary<string, object>() {
  { "company", "EasyPost" },
  { "street1", "417 Montgomery Street" },
  { "street2", "Floor 5" },
  { "city", "San Francisco" },
  { "state", "CA" },
  { "country", "US" },
  { "zip", "94104" }
};

Shipment shipment = await Shipment.Create(new Dictionary<string, object>() {
  { "carrier_accounts", new Dictionary<string, string>() { { “id”, “ca_...” } } },
  { "service", “NextDayAir” }
  { "parcel", new Dictionary<string, object>() {
    { "length", 8 }, { "width", 6 }, { "height", 5 }, { "weight", 10 }
  } },
  { "to_address", toAddress },
  { "from_address", fromAddress },
  { "reference", "ShipmentRef" }
}, withCarbonOffset: true);
