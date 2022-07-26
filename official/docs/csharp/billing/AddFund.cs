using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

bool success = await Billing.FundWallet("2000");

Console.Write(success);
