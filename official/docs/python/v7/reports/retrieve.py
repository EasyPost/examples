import easypost

easypost.api_key = "EASYPOST_API_KEY"

report = easypost.Report.retrieve("<REPORT_ID>")

print(report)
