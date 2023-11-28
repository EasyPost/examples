import easypost

try:
    easypost.Address.create({"strict_verify": True})
except easypost.errors.api.ApiError as error:
    print(error.code)
