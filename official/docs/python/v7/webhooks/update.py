import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

webhook = easypost.Webhook.retrieve("hook_...")

webhook.update()

print(webhook)
