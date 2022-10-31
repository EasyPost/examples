import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

customs_info = easypost.CustomsInfo.retrieve("cstinfo_...")

print(customs_info)
