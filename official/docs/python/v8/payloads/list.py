import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

payload = client.event.retrieve_all_payloads("evt_...")

print(payload)
