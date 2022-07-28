using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

CarrierAccount carrierAccount = await CarrierAccount.Create(new Dictionary<string, object>() {
  { "type", "DhlEcsAccount" },
  { "description", "CA Location DHL eCommerce Solutions Account" },
  { "credentials", new Dictionary<string, object>{
    { "client_id", "123456" },
    { "client_secret", "123abc" },
    { "distribution_center", "USLAX1" },
    { "pickup_id", "123456" }
  } },
  { "test_credentials", new Dictionary<string, object>{
    { "client_id", "123456" },
    { "client_secret", "123abc" },
    { "distribution_center", "USLAX1" },
    { "pickup_id", "123456" }
  } },
});

Console.Write(carrierAccount);
