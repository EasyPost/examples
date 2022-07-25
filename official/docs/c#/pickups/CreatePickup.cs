using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Dictionary<string, object> parameters = new Dictionary<string, object>() {
  { "is_account_address", false },
  { "address", new Dictionary<String, object>(){
    {"id,", "adr_..."}
  } },
  { "shipment", new Dictionary<String, object>(){
    {"id,", "shp_..."}
  } },
  { "min_datetime", "2014-10-20 17:10:00" },
  { "max_datetime", "2014-10-21 10:30:00"},
  { "instructions", "Special pickup instructions" },
  { "reference", "my-first-pickup"}
};

Pickup pickup = await Pickup.Create(parameters);
