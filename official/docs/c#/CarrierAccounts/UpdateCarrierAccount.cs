using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

CarrierAccount ca = await CarrierAccount.Retrieve("ca_...");

Dictionary<string, object> credentials = new Dictionary<string, object>() {
  { "account_number", "B2B2B2" },
};

await ca.Update(new Dictionary<string, object>() {
  { "description", "FL Location UPS Account" },
  { "credentials", credentials },
});
