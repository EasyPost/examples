import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

api_key = client.api_keys.create(mode="test")

print(api_key)
