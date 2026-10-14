import easypost

easypost.api_key = "EASYPOST_API_KEY"

batch = easypost.Batch.retrieve("batch_...")

batch.create_scan_form()

print(batch)
