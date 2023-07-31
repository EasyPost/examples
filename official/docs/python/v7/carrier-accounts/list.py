import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

carrier_accounts = easypost.CarrierAccount.all()

print(carrier_accounts)
