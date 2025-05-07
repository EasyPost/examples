import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

parcel = client.parcel.retrieve("prcl_...")

print(parcel)
