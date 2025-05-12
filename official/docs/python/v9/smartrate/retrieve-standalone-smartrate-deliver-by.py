import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

results = client.smartrate.estimate_delivery_date(
    from_zip="10001",
    to_zip="10002",
    planned_ship_date="2024-07-18",
    carriers=["usps"],
)

print(results)
