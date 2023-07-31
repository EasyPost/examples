import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

events = client.event.all(page_size=5)

print(events)
