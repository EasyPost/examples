using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

User user = await User.RetrieveMe();

await user.Update(new Dictionary() { { "recharge_threshold", 50.00 } });

Console.Write(user);
