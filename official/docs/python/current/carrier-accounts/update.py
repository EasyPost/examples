import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

carrier_account = client.carrier_account.retrieve("ca_...")

updated_carrier_account = client.carrier_account.update(
    carrier_account.id,
    description="FL Location DHL eCommerce Solutions Account",
    credentials={"pickup_id": "abc123"},
)

print(updated_carrier_account)
