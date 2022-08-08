using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

PaymentMethod paymentMethods = await Billing.RetrievePaymentMethods();

Console.WriteLine(JsonConvert.SerializeObject(paymentMethods, Formatting.Indented));
