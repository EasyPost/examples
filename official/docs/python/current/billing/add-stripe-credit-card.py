import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

payment_method = client.referral_customer.add_credit_card_from_stripe(
    referral_api_key="REFERRAL_USER_API_KEY",
    payment_method_id="seti_...",
    priority="primary",
)

print(payment_method)
