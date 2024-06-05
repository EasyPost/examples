import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

try:
    client.address.create({"strict_verify": True})
except easypost.errors.api.ApiError as error:
    print(error.code)
