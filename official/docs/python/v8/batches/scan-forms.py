import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

batch = client.batch.retrieve("batch_...")

batch_with_scan_form = client.batch.create_scan_form(batch.id)

print(batch_with_scan_form)
