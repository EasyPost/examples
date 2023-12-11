import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

event = client.event.retrieve("evt_...")

print(event)
