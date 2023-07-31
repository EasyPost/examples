import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

parcel = client.parcel.retrieve("prcl_...")

print(parcel)
