import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

scan_forms = client.scan_form.all(page_size=5)

print(scan_forms)
