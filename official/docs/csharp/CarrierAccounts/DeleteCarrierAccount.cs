using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

CarrierAccount carrierAccount = await CarrierAccount.Retrieve("ca_...");

await ca.Delete();

Console.WriteLine(JsonConvert.SerializeObject(carrierAccount, Formatting.Indented));