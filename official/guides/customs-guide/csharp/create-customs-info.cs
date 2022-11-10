CustomsInfo customsInfo = await CustomsInfo.Create(new Dictionary<string, object>() {
  { "customs_certify", true }, { "eel_pfc", "NOEEI 30.37(a)" },
  { "customs_signer", "Jarrett Streebin" }, { "contents_type", "gift" },
  { "customs_items", new List<Dictionary<string, object>>() { customsItem1, customsItem2 } }
});
