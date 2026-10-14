import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

report = client.report.retrieve("<REPORT_ID>")

print(report)
