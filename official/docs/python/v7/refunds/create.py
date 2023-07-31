import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

refunds = easypost.Refund.create(
    carrier="USPS",
    tracking_codes=["EZ1000000001"],
)

print(refunds)
