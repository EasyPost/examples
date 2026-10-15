import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

address = client.address.create(
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
