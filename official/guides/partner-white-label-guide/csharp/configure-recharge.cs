using EasyPost;
EasyPost.ClientManager.SetCurrent("<YOUR_PRODUCTION_API_KEY>");

User me = await User.RetrieveMe();
await me.Update(new Dictionary() { { "recharge_threshold", 50.00 } });
