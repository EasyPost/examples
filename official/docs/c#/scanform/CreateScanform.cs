using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Shipment shipment = await Shipment.Create("...");
List<Shipment> shipments = new List<Dictionary<string, object>>() {
    {"id", "shp_..."},
    {"id", "shp_..."}
};
ScanForm scanForm = await ScanForm.Create(shipments);
