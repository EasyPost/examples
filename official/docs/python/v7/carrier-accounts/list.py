import easypost

easypost.api_key = "EASYPOST_API_KEY"

carrier_accounts = easypost.CarrierAccount.all()

print(carrier_accounts)
