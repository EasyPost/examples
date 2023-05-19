import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

carrier_account = client.carrier_account.retrieve("ca_...")

updated_carrier_account = client.carrier_account.update(
    description="FL Location DHL eCommerce Solutions Account",
    credentials={"pickup_id": "abc123"},
)

print(updated_carrier_account)
