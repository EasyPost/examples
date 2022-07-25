using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

CarrierAccount ca = await CarrierAccount.Retrieve("ca_...");

Dictionary<string, object> credentials = new Dictionary<string, object>() {
  { "pickup_id", "abc123" },
};

await ca.Update(new Dictionary<string, object>() {
  { "credentials", credentials },
});
