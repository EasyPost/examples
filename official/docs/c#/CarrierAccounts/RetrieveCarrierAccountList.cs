using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

List<CarrierAccount> carrierAccounts = await CarrierAccount.All();