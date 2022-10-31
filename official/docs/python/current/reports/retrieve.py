import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

report = easypost.Report.retrieve("<REPORT_ID>")

print(report)
