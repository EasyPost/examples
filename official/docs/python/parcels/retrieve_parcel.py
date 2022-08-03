import easypost
easypost.api_key = "EASYPOST_API_KEY"

parcel = easypost.Parcel.retrieve("prcl_...")

print(parcel)
