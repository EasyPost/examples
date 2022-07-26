using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

User childUser = await User.Retrieve("user_..");

await me.Update(new Dictionary() { { "name", "Test Child" } });
