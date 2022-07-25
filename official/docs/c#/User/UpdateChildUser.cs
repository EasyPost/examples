using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

User childUser = await User.Retrieve("Test Child");
