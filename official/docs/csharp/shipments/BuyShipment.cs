using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");


Shipment shipment = await Shipment.Create(new Dictionary<string, object>() {
  { "parcel", new Dictionary<string, object>() {
    { "length", 20.2 },
    { "width", 10.9 },
    { "height", 5 },
    { "weight", 65.9 }
  } },
  { "from_address", new Dictionary<string, object>(){
    { "name", "EasyPost" },
    { "street1", "417 Montgomery Street" },
    { "street2", "5th Floor" },
    { "city", "San Francisco" },
    { "state", "CA" },
    { "zip", "94104" },
    { "country", "US" },
    {"phone", "4153334445"},
    {"email", "support@easypost.com"}
  } },
  { "to_address", new Dictionary<string, object>(){
    { "name", "Dr. Steve Brule" },
    { "street1", "179 N Harbor Dr" },
    { "city", "Redondo Beach" },
    { "state", "CA" },
    { "country", "US" },
    { "phone", "8573875756" },
    { "email", "dr_steve_brule@gmail.com" },
    { "zip", "90277" }
  } }
});

await shipment.Buy(shipment.RetrieveRate("rate_..."), 249.99);

Console.Write(shipment);
