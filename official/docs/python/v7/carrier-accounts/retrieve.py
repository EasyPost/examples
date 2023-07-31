import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

carrier_account = easypost.CarrierAccount.retrieve("ca_...")

print(carrier_account)
