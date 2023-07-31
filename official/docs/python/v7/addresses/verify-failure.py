import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

address = easypost.Address.create(
    street1="UNDELIVERABLE ST",
    city="SAN FRANCISCO",
    state="CA",
    zip="94104",
    country="US",
    company="EasyPost",
    phone="415-123-4567",
)

print(address)
