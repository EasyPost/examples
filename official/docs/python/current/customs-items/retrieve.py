import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

customs_item = client.customs_item.retrieve("cstitem_...")

print(customs_item)
