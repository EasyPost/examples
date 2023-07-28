import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

carrier_account = easypost.CarrierAccount.create(
    type="DhlEcsAccount",
    description="CA Location DHL eCommerce Solutions Account",
    credentials={
        "client_id": "123456",
        "client_secret": "123abc",
        "distribution_center": "USLAX1",
        "pickup_id": "123456",
    },
    test_credentials={
        "client_id": "123456",
        "client_secret": "123abc",
        "distribution_center": "USLAX1",
        "pickup_id": "123456",
    },
)

print(carrier_account)
