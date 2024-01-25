import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

address = client.address.create(
    verify=True,
    street1="000 unknown street",
    city="Not A City",
    state="ZZ",
    zip="00001",
    country="US",
    email="test@example.com",
    phone="5555555555",
)

print(address)
