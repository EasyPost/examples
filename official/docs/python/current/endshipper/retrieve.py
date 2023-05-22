import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

retrieved_endshipper = client.end_shipper.retrieve("es_...")

print(retrieved_endshipper)
