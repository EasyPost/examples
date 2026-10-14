import easypost

easypost.api_key = "EASYPOST_API_KEY"

webhook = easypost.Webhook.retrieve("hook_...")

webhook.update()

print(webhook)
