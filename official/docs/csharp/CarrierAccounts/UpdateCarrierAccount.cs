using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

CarrierAccount carrierAccount = await CarrierAccount.Retrieve("ca_...");

await ca.Update(new Dictionary<string, object>() {
  { "credentials", new Dictionary<string, object>(){
    { "pickup_id", "abc123" },
  } },
});

Console.WriteLine(JsonConvert.SerializeObject(carrierAccount, Formatting.Indented));
