CustomsItem customsItem1 = await CustomsItem.Create(new Dictionary<string, object>() {
  { "description", "T-shirt" },
  { "quantity", 1 },
  { "weight", 6 },
  { "value", 11 },
  { "origin_country", "US" },
  { "hs_tariff_number", "610910" }
});
