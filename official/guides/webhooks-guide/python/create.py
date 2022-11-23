import easypost


easypost.api_key = "<YOUR_TEST/PRODUCTION_API_KEY>"

webhook = easypost.Webhook.create(
    url="https://example.com",
    webhook_secret="A1B2C3",
)
