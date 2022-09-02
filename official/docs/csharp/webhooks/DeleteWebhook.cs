using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Webhook webhook = await Webhook.Retrieve("hook_...");

await webhook.Delete();

Console.WriteLine(JsonConvert.SerializeObject(webhook, Formatting.Indented));
