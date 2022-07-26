using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

CarrierAccount carrier_account = await CarrierAccount.Retrieve("ca_...");

Console.Write(carrier_account);
