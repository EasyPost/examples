using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Batch batch = await Batch.Create(new Dictionary<string, object>() {
  { "shipments", new List<Dictionary<string, object>>() {
    new Dictionary<string, object>() 
      { "id", "shp_..." },
      {"id", "shp_..."} 
  } }
});

Console.Write(batch);
