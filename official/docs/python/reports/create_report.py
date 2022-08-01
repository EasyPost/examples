import easypost
easypost.api_key = "EASYPOST_API_KEY"

report = easypost.Report.create(
  start_date="2016-10-01",
  end_date="2016-10-31",
)

print(report)
