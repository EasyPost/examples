import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

address = client.address.verify("adr_...")

print(address)
