using EasyPost;
EasyPost.ClientManager.SetCurrent("<YOUR_PRODUCTION_API_KEY>");

bool success = await Billing.FundWallet("2000", PaymentMethod.Priority.Primary);
