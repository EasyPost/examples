using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

List<Webhook> webhooks = await Webhook.All();

Console.WriteLine(JsonConvert.SerializeObject(webhooks, Formatting.Indented));
