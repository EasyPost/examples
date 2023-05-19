import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

carrier_account = easypost.CarrierAccount.retrieve("ca_...")

carrier_account.description = "FL Location DHL eCommerce Solutions Account"
carrier_account.credentials["pickup_id"] = "abc123"
carrier_account.save()

print(carrier_account)
