import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

api_key = client.api_keys.enable("ak_...")

print(api_key)
