import easypost
easypost.api_key = "EASYPOST_API_KEY"

address = easypost.Address.retrieve("adr_...")

print(address)
