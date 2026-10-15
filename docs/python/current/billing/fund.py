import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

client.billing.fund_wallet(
    amount="2000",
    primary_or_secondary="primary",
)
