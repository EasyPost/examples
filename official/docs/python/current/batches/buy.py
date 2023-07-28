import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

batch = client.batch.retrieve("batch_...")

bought_batch = client.batch.buy(batch.id)

print(bought_batch)
