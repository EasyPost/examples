using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Dictionary<string, object> listParams = new Dictionary<string, object>() {
  { "page_size", 5 }
};

ShipmentCollection shipmentCollection = await Shipment.All(listParams);

Console.WriteLine(JsonConvert.SerializeObject(shipmentCollection, Formatting.Indented));
