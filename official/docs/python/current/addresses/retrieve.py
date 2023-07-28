import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

address = client.address.retrieve("adr_...")

print(address)
