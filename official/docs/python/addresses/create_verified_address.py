import easypost
easypost.api_key = "EASYPOST_API_KEY"

address = easypost.Address.create(
    verify=True,
    street1="417 Montgomery Streat",
    street2="5",
    city="SF",
    state="CA",
    zip="94104",
    country="US",
    company="EasyPost",
    phone="415-123-4567"
)

print(address)
