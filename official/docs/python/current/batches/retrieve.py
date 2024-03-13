import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

batch = client.batch.retrieve("batch_...")

print(batch)
