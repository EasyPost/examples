using EasyPost;
EasyPost.ClientManager.SetCurrent("<YOUR_TEST/PRODUCTION_API_KEY>");

Webhook webhook = await Webhook.Create(
    new Dictionary<string, object>() {
        { "url", "https://example.com" },
        { "webhook_secret", "A1B2C3" }
    }
);
