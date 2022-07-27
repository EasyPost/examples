using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

CustomsInfo customsInfo = await CustomsInfo.Create(new Dictionary<string, object>() {
  { "customs_certify", true },
  {"customs_signer", "Steve Brule"},
  {"contents_type", "merchandise"},
  {"contents_explanation", ""},
  { "eel_pfc", "NOEEI 30.37(a)" },
  { "customs_items", new List<Dictionary<string, object>>()
      { new Dictionary<string, object>(){
        { "description", "T-shirt" },
        { "quantity", 1 },
        { "weight", 5 },
        {"value", 10},
        {"hs_tariff_number", "123456"},
        { "origin_country", "US" }
    } }
  },
  {"restriction_type", "none"},
  {"eel_pfc", "NOEEI 30.37(a)"}
});

Console.Write(customsInfo);
