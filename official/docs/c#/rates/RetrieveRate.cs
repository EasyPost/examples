using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Rate rate = await Rate.Retrieve("rate...");
