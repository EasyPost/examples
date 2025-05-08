import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

updated_webhook = client.webhook.update("hook_...")

print(updated_webhook)
