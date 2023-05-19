import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

webhooks = client.webhook.all()

print(webhooks)
