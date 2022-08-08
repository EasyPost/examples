import easypost


easypost.api_key = "EASYPOST_API_KEY"

carrier_account = easypost.CarrierAccount.retrieve("ca_...")

print(carrier_account)
