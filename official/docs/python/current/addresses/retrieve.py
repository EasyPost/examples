import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

address = client.address.retrieve("adr_...")

print(address)
