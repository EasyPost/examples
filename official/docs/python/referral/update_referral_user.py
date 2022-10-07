import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

referral_users = easypost.Referral.all(page_size=5)

referral_users_array = referral_users["referral_customers"]

updated_referral_user = easypost.Referral.update_email(
    "email@example.com",
    referral_users_array[0].id,
)

print(updated_referral_user)
