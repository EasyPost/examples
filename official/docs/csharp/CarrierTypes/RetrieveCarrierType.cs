using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

CarrierType CarrierTypes = await CarrierType.All();

console.write(CarrierTypes);
