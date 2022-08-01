using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Shipment purchasedShipment = await Shipment.Retrieve("shp_...");

await purchasedShipment.Insure(100);

Console.WriteLine(JsonConvert.SerializeObject(purchasedShipment, Formatting.Indented));
