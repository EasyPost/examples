import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

payment_method = easypost.beta.Referral.add_payment_method(
    stripe_customer_id="cus_123",
    payment_method_reference="ba_123",
    primary_or_secondary="primary",
)

print(payment_method)
