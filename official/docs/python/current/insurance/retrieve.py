import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

insurance = client.insurance.retrieve("ins_...")

print(insurance)
