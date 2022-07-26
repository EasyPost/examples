using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

await shipment.Buy(shipment.RetrieveRate("rate_..."), 249.99);
