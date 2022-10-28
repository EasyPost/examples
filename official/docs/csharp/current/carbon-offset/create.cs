using EasyPost;

EasyPost.ClientManager.SetCurrent("<YOUR_TEST/PRODUCTION_API_KEY>");

Address toAddress = await Address.Create(toAddress);
Address fromAddress = await Address.Create(fromAddress);
Parcel parcel = await Parcel.Create(parcel);
CustomsInfo customs = await CustomsInfo.Create(customsInfo);

Shipment shipment = await Shipment.Create(new Dictionary<string, object>() {
  { "to_address", toAddress },
  { "from_address", fromAddress },
  { "parcel", parcel },
  { "customs_info", customs }
}, withCarbonOffset: true);
