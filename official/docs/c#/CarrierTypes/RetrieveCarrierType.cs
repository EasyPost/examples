using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

await CarrierType.All();