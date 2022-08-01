import easypost
easypost.api_key = "EASYPOST_API_KEY"

reports = easypost.Report.all(
    # Replace `payment_log` with any of the report types listed above
    type='payment_log',
    page_size=4,
    start_date='2016-01-02'
)

print(reports)
