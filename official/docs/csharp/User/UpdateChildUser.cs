using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

User childUser = await User.Retrieve("user_..");

await childUser.Update(new Dictionary() { 
    { "name", "Test Child" } 
});

Console.Write(childUser);
