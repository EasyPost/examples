import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

payload = client.event.retrieve_all_payloads("evt_...")

print(payload)
