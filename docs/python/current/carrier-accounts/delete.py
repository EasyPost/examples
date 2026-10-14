import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

client.carrier_account.delete("ca_...")
