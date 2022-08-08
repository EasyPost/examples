using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

User user = await User.RetrieveMe();

await user.Update(new Dictionary<string, object>(){
    { "color", "#303F9F" }
});

Console.WriteLine(JsonConvert.SerializeObject(user, Formatting.Indented));
