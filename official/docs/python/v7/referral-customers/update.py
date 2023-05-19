import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

easypost.Referral.update_email(
    "new_email@example.com",
    "user_...",
)
