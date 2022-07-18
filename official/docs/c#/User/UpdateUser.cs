using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

User me = await User.RetrieveMe();
await me.Update(new Dictionary() { { "recharge_threshold", 50.00 } });
