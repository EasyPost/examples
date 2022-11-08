import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

updated_referral_user = easypost.Referral.update_email(
    "new_email@example.com",
    "user_...",
)

print(updated_referral_user)
