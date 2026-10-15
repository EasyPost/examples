import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

addresses = client.address.all(page_size=5)

print(addresses)
