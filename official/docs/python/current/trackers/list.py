import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

trackers = client.tracker.all(page_size=5)

print(trackers)
