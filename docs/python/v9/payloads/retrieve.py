import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

payload = client.event.retrieve_payload("evt_...", "payload_...")

print(payload)
