import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

webhooks = client.webhook.all()

print(webhooks)
