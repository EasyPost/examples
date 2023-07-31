import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

tracker = easypost.Tracker.create(
    tracking_code="EZ1000000001",
    carrier="USPS",
)

print(tracker)
