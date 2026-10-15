import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

trackers = client.tracker.retrieve_batch(
    tracking_codes=["EZ1000000001", "EZ1000000002"],
)

print(trackers)
