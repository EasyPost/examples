import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

parcel = client.parcel.create(
    length=20.2,
    width=10.9,
    height=5,
    weight=65.9,
)

print(parcel)
