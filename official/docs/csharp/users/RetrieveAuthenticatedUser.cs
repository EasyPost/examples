using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

User user = await User.RetrieveMe();

Console.WriteLine(JsonConvert.SerializeObject(user, Formatting.Indented));
