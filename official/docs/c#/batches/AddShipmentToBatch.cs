using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Shipment shipment = await Shipment.Retrieve("shp_...");

Batch batch = await Batch.Retrieve("batch_...");

batch.AddShipments("shipments", new List<Dictionary<string, object>>(){
    new Dictionary<string, object>(){
        { "id", "shp_..."},
        { "id", "shp_..."}
     }
    }
 );
