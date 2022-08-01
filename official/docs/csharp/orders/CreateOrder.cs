using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Order order = await Order.Create(
    new Dictionary<string, object>() {
    {
        "to_address", new Dictionary<string, object>(){
            { "id", "adr_..." }
        }
    },
    {
        "from_address", new Dictionary<string, object>(){
            { "id", "adr_..." }
        }
    },
    {
         "shipments", new List<Dictionary<string, object>>(){
            {
                "parcel", new Dictionary<string, object>(){
                    { "weight", 10.2 }
                }
            },
            {
                "parcel", new Dictionary<string, object>() {
                    { "weight", 17.5 },
                    { "predefined_package", "FedExBox" }
                }
            }
        }
    }
});

Console.WriteLine(JsonConvert.SerializeObject(order, Formatting.Indented));
