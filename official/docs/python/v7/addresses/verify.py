import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

address = easypost.Address.create(
    street1="417 MONTGOMERY ST",
    street2="FLOOR 5",
    city="San Francisco",
    state="CA",
    zip="94104",
    country="US",
    company="EasyPost",
    phone="415-123-4567",
)

address.verify()

print(address)
