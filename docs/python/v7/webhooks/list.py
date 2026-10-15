import easypost

easypost.api_key = "EASYPOST_API_KEY"

webhooks = easypost.Webhook.all()

print(webhooks)
