import easypost

easypost.api_key = "EASYPOST_API_KEY"

batches = easypost.Batch.all(page_size=5)

print(batches)
