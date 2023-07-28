import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

report = client.report.retrieve("<REPORT_ID>")

print(report)
