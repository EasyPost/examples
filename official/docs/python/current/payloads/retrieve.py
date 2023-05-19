import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

payload = client.event.retrieve_payload("evt_...", "payload_...")

print(payload)
