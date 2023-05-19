import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

referral_users = client.referral_customer.all(page_size=5)

print(referral_users)
