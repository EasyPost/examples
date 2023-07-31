import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

referral_user = easypost.Referral.create(
    name="test test",
    email="test@test.com",
    phone="8888888888",
)

print(referral_user)
