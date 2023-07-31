import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

report = easypost.Report.create(
    type="payment_log",
    start_date="2022-10-01",
    end_date="2022-10-31",
)

print(report)
