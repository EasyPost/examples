using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Order order = await Order.Create(new Dictionary<string, object>() {
  { "carrier_accounts",
    new List<String>(){
        "ca_..."
  } },
  { "service", "NextDayAir" },
  { "to_address", new Dictionary<string, string>()
    { "id", "adr_..."}
  },
  { "from_address", new Dictionary<string, string>()
    { "id", "adr_..." }
  },
  { "shipments", new List<Dictionary<string, object>>(){
    {
        "parcel", new Dictionary<string, object>()
        {
            { "weight", 10.2 }
        }
     },
     {
        "parcel", new Dictionary<string, object>()
        {
            { "predefined_package", "FedExBox" },
            { "weight", 17.5 }
        }
    }
    } }
});

Console.WriteLine(JsonConvert.SerializeObject(order, Formatting.Indented));
