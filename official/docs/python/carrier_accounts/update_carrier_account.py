import easypost
easypost.api_key = "EASYPOST_API_KEY"

carrier_account = easypost.CarrierAccount.retrieve("ca_...")

carrier_account.credentials["pickup_id"] = "abc123"
carrier_account.save()

print(carrier_account)
