import easypost

easypost.api_key = "EASYPOST_API_KEY"

customs_item = easypost.CustomsItem.retrieve("cstitem_...")

print(customs_item)
