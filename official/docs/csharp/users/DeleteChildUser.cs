using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

User user = await User.Retrieve("user_...");

await user.delete();

Console.WriteLine(JsonConvert.SerializeObject(user, Formatting.Indented));
