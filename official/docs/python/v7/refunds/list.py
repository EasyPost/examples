import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

refunds = easypost.Refund.all(
    page_size=5,
)

print(refunds)
