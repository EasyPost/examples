import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

payment_method = client.referral_customer.add_credit_card_from_stripe(
    referral_api_key="REFERRAL_CUSTOMER_PROD_API_KEY",
    financial_connections_id="seti_...",
    priority="primary",
)

print(payment_method)
