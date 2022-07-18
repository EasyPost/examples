using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

CarrierAccount ca = await CarrierAccount.Retrieve("ca_...");
await ca.Delete();
