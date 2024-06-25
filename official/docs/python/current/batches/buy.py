import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

batch = client.batch.buy("batch_...")

print(batch)
