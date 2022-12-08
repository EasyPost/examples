import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

referral_user_api_key = os.getenv("REFERRAL_USER_API_KEY")

credit_card = easypost.Referral.add_credit_card(
    referral_api_key=referral_user_api_key,
    number="0123456789101234",
    expiration_month="01",
    expiration_year="2028",
    cvc="111",
)

print(credit_card)
