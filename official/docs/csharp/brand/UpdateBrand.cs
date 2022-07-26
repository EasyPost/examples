using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

User user = await User.RetrieveMe();

await user.Update(new Dictionary<string, object>(){
    { "color", color }
});

Console.Write(brand);
