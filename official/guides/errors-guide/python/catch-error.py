import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

# When the `errors` key is returned as an array of FieldError objects
try:
    # Simulate a request with missing parameters
    client.shipment.create({})
except easypost.errors.api.ApiError as error:
    print(error.errors[0]["message"])

# When the `errors` key is returned as an array of strings
try:
    client.claim.create(
        tracking_code="123",  # Simulate a request with an invalid tracking code
    )
except easypost.errors.api.ApiError as error:
    print(error.errors[0])
