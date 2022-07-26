using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Dictionary<string, object> firstShipment = new Dictionary<string, object>() {
    { 
        "parcel", new Dictionary<string, object>()
        {
            { "weight", 10.2 }
        }
    }
};

Dictionary<string, object> secondShipment = new Dictionary<string, object>() {
    {
        "parcel", new Dictionary<string, object>() 
        {
            { "predefined_package", "FedExBox" },
            { "weight", 17.5 }
        }
    }
};

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
    {"id", "adr_..."}
  },
  { "shipments", new List<Dictionary<string, object>>() 
    {
        firstShipment,
        secondShipment 
    } }
});
