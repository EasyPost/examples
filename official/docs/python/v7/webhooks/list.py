import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

webhooks = easypost.Webhook.all()

print(webhooks)
