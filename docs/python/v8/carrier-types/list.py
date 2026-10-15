import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

carrier_types = client.carrier_account.types()

print(carrier_types)
