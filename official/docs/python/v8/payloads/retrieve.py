import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

payload = client.event.retrieve_payload("evt_...", "payload_...")

print(payload)
