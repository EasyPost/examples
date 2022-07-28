using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

CarrierAccount carrierAccount = await CarrierAccount.Retrieve("ca_...");

Console.Write(carrierAccount);
