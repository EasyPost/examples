using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Address address = await Address.Retrieve("adr_...");

Console.WriteLine(JsonConvert.SerializeObject(address, Formatting.Indented));
