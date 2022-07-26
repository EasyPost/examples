using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Shipment purchasedShipment = await Shipment.Retrieve("shp_...");
await purchasedShipment.Insure(888.50);

Console.Write(purchasedShipment);
