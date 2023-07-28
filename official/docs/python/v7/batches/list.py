import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

batches = easypost.Batch.all(page_size=5)

print(batches)
