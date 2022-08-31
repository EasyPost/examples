import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

address = easypost.Address.create(
    street1="417 MONTGOMERY ST",
    street2="FLOOR 5",
    city="SAN FRANCISCO",
    state="CA",
    zip="94104",
    country="US",
    company="EasyPost",
    phone="415-123-4567",
)

print(address)
