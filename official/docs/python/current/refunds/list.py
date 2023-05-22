import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

refunds = client.refund.all(
    page_size=5,
)

print(refunds)
