import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

address = client.address.create(
    street1="417 MONTGOMERY ST",
    street2="FLOOR 5",
    city="San Francisco",
    state="CA",
    zip="94104",
    country="US",
    company="EasyPost",
    phone="415-123-4567",
)

verified_address = client.address.verify(address.id)

print(verified_address)
