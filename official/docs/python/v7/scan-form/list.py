import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

scan_forms = easypost.ScanForm.all(page_size=5)

print(scan_forms)
