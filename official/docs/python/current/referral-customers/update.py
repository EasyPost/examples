import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

client.referral_customer.update_email(
    "new_email@example.com",
    "user_...",
)
