import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

address = client.address.create(
    street1="UNDELIVERABLE ST",
    city="SAN FRANCISCO",
    state="CA",
    zip="94104",
    country="US",
    company="EasyPost",
    phone="415-123-4567",
)

print(address)
