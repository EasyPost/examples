import easypost

easypost.api_key = "EASYPOST_API_KEY"

scan_form = easypost.ScanForm.retrieve("sf_...")

print(scan_form)
