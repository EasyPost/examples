import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

refund = easypost.Refund.retrieve("rfnd_...")

print(refund)
