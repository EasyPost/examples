using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

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
  { "tax_identifiers", new List<Dictionary<string, object>>() { 
    { "entity", "SENDER" },
    { "tax_id", "GB123456789" },
    { "tax_id_type", "IOSS" },
    { "issuing_country", "GB" }
  } }
});
