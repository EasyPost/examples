import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

payment_method = client.beta_referral_customer.add_payment_method(
    stripe_customer_id="cus_...",
    payment_method_reference="ba_...",
    primary_or_secondary="primary",
)

print(payment_method)
