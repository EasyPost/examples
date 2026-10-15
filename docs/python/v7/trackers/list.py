import easypost

easypost.api_key = "EASYPOST_API_KEY"

trackers = easypost.Tracker.all(
    page_size=5,
)

print(trackers)
