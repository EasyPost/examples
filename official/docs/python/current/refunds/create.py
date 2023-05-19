import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

refunds = client.refund.create(
    carrier="USPS",
    tracking_codes=["EZ1000000001"],
)

print(refunds)
