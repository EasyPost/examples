import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

tracker = client.tracker.retrieve("trk_...")

print(tracker)
