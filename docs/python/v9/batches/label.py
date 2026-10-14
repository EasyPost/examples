import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

batch = client.batch.label("batch_...", file_format="PDF")

print(batch)
