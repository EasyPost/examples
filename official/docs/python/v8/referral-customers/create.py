import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

referral_user = client.referral_customer.create(
    name="test test",
    email="test@test.com",
    phone="8888888888",
)

print(referral_user)
