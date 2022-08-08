import easypost


easypost.api_key = "EASYPOST_API_KEY"

addresses = easypost.Address.all(page_size=5)

print(addresses)
