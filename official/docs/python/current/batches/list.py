import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

batches = client.batch.all(page_size=5)

print(batches)
