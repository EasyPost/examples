import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

payload = easypost.Event.retrieve_all_payloads("evt_...")

print(payload)
