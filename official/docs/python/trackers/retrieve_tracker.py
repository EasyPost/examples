import easypost


easypost.api_key = "EASYPOST_API_KEY"

tracker = easypost.Tracker.retrieve("trk_...")
ß
print(tracker)
