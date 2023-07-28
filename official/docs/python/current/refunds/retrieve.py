import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

refund = client.refund.retrieve("rfnd_...")

print(refund)
