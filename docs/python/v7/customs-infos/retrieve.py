import easypost

easypost.api_key = "EASYPOST_API_KEY"

customs_info = easypost.CustomsInfo.retrieve("cstinfo_...")

print(customs_info)
