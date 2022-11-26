import easypost


easypost.api_key = "<YOUR_PRODUCTION_API_KEY>"

success = easypost.Billing.fund_wallet(
    amount="2000",
    primary_or_secondary="primary",
)
