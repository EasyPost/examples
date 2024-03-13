import easypost

easypost.api_key = "EASYPOST_API_KEY"

payload = easypost.Event.retrieve_payload("evt_...", "payload_...")

print(payload)
