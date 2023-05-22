import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

parcel = client.parcel.retrieve("prcl_...")

print(parcel)
