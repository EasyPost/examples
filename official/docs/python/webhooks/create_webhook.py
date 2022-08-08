import easypost


easypost.api_key = "EASYPOST_API_KEY"

webhook = easypost.Webhook.create(url="example.com")

print(webhook)
