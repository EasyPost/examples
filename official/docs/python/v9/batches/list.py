import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

batches = client.batch.all(page_size=5)

print(batches)
