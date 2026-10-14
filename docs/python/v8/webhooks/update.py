import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

webhook = client.webhook.retrieve("hook_...")

updated_webhook = client.webhook.update(webhook.id)

print(updated_webhook)
