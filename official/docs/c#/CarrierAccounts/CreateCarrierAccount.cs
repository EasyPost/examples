using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Dictionary<string, object> credentials = new Dictionary<string, object>() {
  { "client_id", "123456" },
  { "client_secret", "123abc" },
  { "distribution_center", "USLAX1" },
  { "pickup_id", "123456" }
};

Dictionary<string, object> testCredentials = new Dictionary<string, object>() {
  { "client_id", "123456" },
  { "client_secret", "123abc" },
  { "distribution_center", "USLAX1" },
  { "pickup_id", "123456" }
};

await CarrierAccount.Create(new Dictionary<string, object>() {
  { "type", "DhlEcsAccount" },
  { "description", "CA Location DHL eCommerce Solutions Account" },
  { "credentials", credentials },
  { "test_credentials", testCredentials },
});
