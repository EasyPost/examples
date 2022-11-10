Dictionary<string, object> addressData = new Dictionary<string, object>() {
  {"name", "George Costanza"},
  {"company", "Vandelay Industries"}
  {"street1", "1 E 161st St."},
  {"city", "Bronx"},
  {"state", "NY"},
  {"zip", "10451"}
};

Address toAddress = await Address.Create(addressData);
