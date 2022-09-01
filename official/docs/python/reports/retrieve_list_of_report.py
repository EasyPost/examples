import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

reports = easypost.Report.all(
    # Replace `payment_log` with any of the report types listed above
    type="payment_log",
    page_size=5,
    start_date="2022-10-01",
)

print(reports)
