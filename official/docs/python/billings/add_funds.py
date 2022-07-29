import easypost
easypost.api_key = "EASYPOST_API_KEY"

billing = easypost.Billing.fund_wallet(
    amount="2000",
    primary_or_secondary="primary",
)

print(billing)
