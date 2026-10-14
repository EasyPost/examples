import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

address = client.address.create_and_verify(
    street1="417 Montgomery Street",
    street2="FL 5",
    city="San Francisco",
    state="CA",
    zip="94104",
    country="US",
    company="EasyPost",
    phone="415-123-4567",
)

print(address)
