import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

batch = client.batch.create_scan_form("batch_...")

print(batch)
