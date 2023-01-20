import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

refunds = easypost.Refund.create(
    carrier="USPS",
    tracking_codes=["XXXXX"],
)

print(refunds)
