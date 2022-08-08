using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Shipment shipment = await Shipment.Retrieve("shp_...");

await shipment.Refund();

Console.WriteLine(JsonConvert.SerializeObject(shipment, Formatting.Indented));
