Dictionary<string, object> fromAddressData = new Dictionary<string, object>() {
  { "company", "EasyPost" },
  { "street1", "417 Montgomery Street" },
  { "street2", "5th Floor" },
  { "city", "San Francisco" },
  { "state", "CA" },
  { "country", "US" },
  { "zip", "94104" }
};
Dictionary<string, object> toAddressData = new Dictionary<string, object>() {
  { "name", "Tim Canterbury" },
  { "company", "Wernham Hogg" },
  { "street1", "118 Clippenham Lane" },
  { "city", "Slough" },
  { "country", "GB" },
  { "zip", "SL15BE" }
};
Dictionary<string, object> parcelData = new Dictionary<string, object>() {
  { "length", 9 },
  { "width", 6 },
  { "height", 3 },
  { "weight", 20 }
};
Shipment shipment = await Shipment.Create(new Dictionary<string, object>() {
  { "to_address", toAddressData },
  { "from_address", fromAddressData },
  { "parcel", parcelData },
  { "customs_info", customs_info }
});
