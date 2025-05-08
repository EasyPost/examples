import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

payment_method = client.referral_customer.add_bank_account_from_stripe(
    referral_api_key="REFERRAL_USER_API_KEY",
    financial_connections_id="fca_...",
    mandate_data={
        "ip_address": "127.0.0.1",
        "user_agent": "Mozilla/5.0",
        "accepted_at": 172251073,
    },
    priority="primary",
)

print(payment_method)
