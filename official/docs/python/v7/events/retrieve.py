import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

event = easypost.Event.retrieve("evt_...")

print(event)
