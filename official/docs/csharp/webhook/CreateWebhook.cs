using EasyPost;

EasyPost.ClientManager.SetCurrent("EASYPOST_API_KEY");

Webhook webhook = await Webhook.Create(
    new Dictionary<string, object>() {
        { "url", "example.com" }
    }
);

Console.WriteLine(JsonConvert.SerializeObject(webhook, Formatting.Indented));
