using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

CarrierType carrierTypes = await CarrierType.All();

Console.WriteLine(JsonConvert.SerializeObject(carrierTypes, Formatting.Indented));
