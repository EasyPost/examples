using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

ApiKeys api_keys = await ApiKeys.All();

Console.Write(api_keys);
