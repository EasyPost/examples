# Import the EasyPost client.
import easypost


# Setup the client with your API key.
easypost.api_key = "259DA788-39A3-439E-BA1E-BC541B8BA520"

# Create and verify an address.
easypost.Address.create(
    verify=True,
    street1="417 Montgomery Street",
    street2="FL 5",
    city="San Francisco",
    state="CA",
    zip="94104",
    country="US",
    company="EasyPost",
)
