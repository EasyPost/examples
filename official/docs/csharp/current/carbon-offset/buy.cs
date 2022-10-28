using EasyPost;

EasyPost.ClientManager.SetCurrent("<YOUR_TEST/PRODUCTION_API_KEY>");

Shipment shipment = await Shipment.Retrieve("shp_...");
await shipment.Buy(shipment.LowestRate(), withCarbonOffset: true);
