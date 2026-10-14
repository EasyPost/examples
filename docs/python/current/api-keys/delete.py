import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

client.api_keys.delete("ak_...")
