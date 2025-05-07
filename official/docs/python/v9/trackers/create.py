import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

tracker = client.tracker.create(
    tracking_code="EZ1000000001",
    carrier="USPS",
)

print(tracker)
