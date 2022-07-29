import easypost
easypost.api_key = "EASYPOST_API_KEY"

batch = easypost.Batch.retrieve("batch_...")

print(batch)
