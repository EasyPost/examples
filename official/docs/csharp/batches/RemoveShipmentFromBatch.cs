using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Batch batch = await Batch.Retrieve("batch_...");

batch.RemoveShipments("shipments", new List<Dictionary<string, object>>(){
    new Dictionary<string, object>(){
        { "id", "shp_..."}
     }
    }
 );

Console.Write(batch);
