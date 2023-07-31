import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

parcel = easypost.Parcel.create(
    length=20.2,
    width=10.9,
    height=5,
    weight=65.9,
)

print(parcel)
