using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

shipment = EasyPost::Shipment.retrieve("shp_...");
shipment.refund;
