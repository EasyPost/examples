import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

referral_users = easypost.Referral.all(page_size=5)

referral_users_array = referral_users["referral_customers"]

print(referral_users_array)
