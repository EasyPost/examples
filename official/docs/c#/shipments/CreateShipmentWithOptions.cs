using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Address to = await Address.Create(toAddress);
Address from = await Address.Create(fromAddress);
Parcel parcel = await Parcel.Create(parcel);

Shipment shipment = await Shipment.Create(new Dictionary<string, object>() {
  { "parcel", new Dictionary<string, object>() {
    { "length", 8 }, { "width", 6 }, { "height", 5 }, { "weight", 10 }
  } },
  { "to_address", new Dictionary<string, object>(){
    { "company", "EasyPost" },
    { "street1", "417 Montgomery Street" },
    { "street2", "Floor 5" },
    { "city", "San Francisco" },
    { "state", "CA" },
    { "country", "US" },
    { "zip", "94104" }
  } },
  { "from_address", new Dictionary<string, object>(){
    { "name", "Dr. Steve Brule" },
    { "street1", "417 Montgomery Street" },
    { "street2", "5th Floor" },
    { "city", "San Francisco" },
    { "state", "CA" },
    { "country", "US" },
    { "zip", "94104" }
  } },
  { "reference", "ShipmentRef" },
  { "options", new Dictionary<string, object>() { { "address_validation_level", 0 } } }
});
