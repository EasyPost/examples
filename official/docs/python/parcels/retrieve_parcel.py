import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

parcel = easypost.Parcel.retrieve("prcl_...")

print(parcel)
