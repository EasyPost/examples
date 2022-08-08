import easypost


easypost.api_key = "EASYPOST_API_KEY"

address = easypost.Address.create(
    verify_strict=True,
    street1="417 MONTGOMERY ST",
    street2="FLOOR 5",
    city="San Francisco",
    state="CA",
    zip="94104",
    country="US",
    company="EasyPost",
    phone="415-123-4567",
)

print(address)
