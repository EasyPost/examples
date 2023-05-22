import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

report = client.report.create(
    type="payment_log",
    start_date="2022-10-01",
    end_date="2022-10-31",
)

print(report)
