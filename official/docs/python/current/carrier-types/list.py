import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

carrier_types = client.carrier_account.types()

print(carrier_types)
