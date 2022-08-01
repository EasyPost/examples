using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

User user = await User.Create(new Dictionary<string, object>() {
  { "name", "Child Account Name" }
});

Console.WriteLine(JsonConvert.SerializeObject(user, Formatting.Indented));
