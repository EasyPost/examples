import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

tracker = client.tracker.retrieve("trk_...")

print(tracker)
