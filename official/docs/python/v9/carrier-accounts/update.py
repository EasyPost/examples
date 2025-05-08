import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

updated_carrier_account = client.carrier_account.update(
    "ca_...",
    description="FL Location DHL eCommerce Solutions Account",
    credentials={"pickup_id": "abc123"},
)

print(updated_carrier_account)
