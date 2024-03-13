import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

carrier_account = client.carrier_account.retrieve("ca_...")

client.carrier_account.delete(carrier_account.id)
