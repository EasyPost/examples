import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

customs_item = easypost.CustomsItem.retrieve("cstitem_...")

print(customs_item)
