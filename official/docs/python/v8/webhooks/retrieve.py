import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

webhook = client.webhook.retrieve("hook_...")

print(webhook)
