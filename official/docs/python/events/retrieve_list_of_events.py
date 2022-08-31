import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

events = easypost.Events.all(page_size=5)

print(events)
