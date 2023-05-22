import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

refund = client.refund.retrieve("rfnd_...")

print(refund)
