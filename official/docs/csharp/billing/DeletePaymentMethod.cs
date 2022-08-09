using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

bool success = await Billing.DeletePaymentMethod(PaymentMethod.Priority.Primary);

Console.WriteLine(JsonConvert.SerializeObject(success, Formatting.Indented));
