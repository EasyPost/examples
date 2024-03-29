import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

payment_method = client.beta_referral_customer.add_payment_method(
    stripe_customer_id="cus_...",
    payment_method_reference="card_...",
    primary_or_secondary="primary",
)

print(payment_method)
