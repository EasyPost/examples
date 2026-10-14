import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

webhook = client.webhook.retrieve("hook_...")

client.webhook.delete(webhook.id)
