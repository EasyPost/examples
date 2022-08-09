using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

ApiKeys api_keys = await ApiKeys.All();

Console.WriteLine(JsonConvert.SerializeObject(api_keys, Formatting.Indented));
