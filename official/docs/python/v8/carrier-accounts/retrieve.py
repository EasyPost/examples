import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

carrier_account = client.carrier_account.retrieve("ca_...")

print(carrier_account)
