import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

webhook = client.webhook.retrieve("hook_...")

print(webhook)
