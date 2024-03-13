import easypost

easypost.api_key = "EASYPOST_API_KEY"

payload = easypost.Event.retrieve_all_payloads("evt_...")

print(payload)
