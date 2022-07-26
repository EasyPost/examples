using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Address to = await Address.Create(toAddress);
Address from = await Address.Create(fromAddress);
Parcel parcel = await Parcel.Create(parcel);

Shipment shipment = await Shipment.Create(new Dictionary<string, object>() {
  { "parcel", new Dictionary<string, object>() {
    {"id", "prcl_..."}
  } },
  { "to_address", new Dictionary<string, object>(){
    {"id", "adr_..."}
  } },
  { "from_address", new Dictionary<string, object>(){
    {"id", "adr_..."}
  }},
  { "options", new Dictionary<string, object>() {
     { "address_validation_level", 0 }
  } }
});
