import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

trackers = client.tracker.all(
    page_size=5,
)

print(trackers)
