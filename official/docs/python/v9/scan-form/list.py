import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

scan_forms = client.scan_form.all(page_size=5)

print(scan_forms)
