import easypost


easypost.api_key = "EASYPOST_API_KEY"

tracker = easypost.Tracker.create(
    tracking_code="9400110898825022579493",
    carrier="USPS",
)

print(tracker)
