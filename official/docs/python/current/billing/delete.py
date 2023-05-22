import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

client.billing.delete_payment_method(primary_or_secondary="primary")
