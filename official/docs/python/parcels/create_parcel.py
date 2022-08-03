import easypost
easypost.api_key = "EASYPOST_API_KEY"

parcel = easypost.Parcel.create(
  length=20.2,
  width=10.9,
  height=5,
  weight=65.9
)

print(parcel)
