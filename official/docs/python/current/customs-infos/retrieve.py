import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

customs_info = client.customs_info.retrieve("cstinfo_...")

print(customs_info)
