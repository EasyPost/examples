import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

address = client.address.retrieve("adr_...")

print(address)
