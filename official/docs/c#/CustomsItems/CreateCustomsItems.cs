using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

CustomsItem item = await CustomsItem.Create(new Dictionary<string, object>() {
  { "description", "T-shirt" },
  { "quantity", 1 },
  { "weight", 5 },
  { "value", 10 },
  { "origin_country", "US" },
  { "hs_tariff_number", "123456" }
});
