import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

batch = client.batch.retrieve("batch_...")

print(batch)
