import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

batch = client.batch.retrieve("batch_...")

batch_with_label = client.batch.label(batch.id, file_format="PDF")

print(batch_with_label)
