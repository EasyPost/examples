using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

purchased_shipment = EasyPost::Shipment.retrieve("shp_...");
purchased_shipment.insure(amount:888.50);
