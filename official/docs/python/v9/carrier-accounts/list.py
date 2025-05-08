import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

carrier_accounts = client.carrier_account.all()

print(carrier_accounts)
