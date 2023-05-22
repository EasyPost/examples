import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

carrier_accounts = client.carrier_account.all()

print(carrier_accounts)
