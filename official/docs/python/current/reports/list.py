import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

reports = client.report.all(
    # Replace `payment_log` with any of the report types listed above
    type="payment_log",
    page_size=5,
)

print(reports)
