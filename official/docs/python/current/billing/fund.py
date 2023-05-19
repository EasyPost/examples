import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

client.billing.fund_wallet(
    amount="2000",
    primary_or_secondary="primary",
)
