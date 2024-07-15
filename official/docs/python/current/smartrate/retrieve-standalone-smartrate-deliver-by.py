import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

params = {
    "from_zip": "10001",
    "to_zip": "10002",
    "planned_ship_date": "2024-07-18",
    "carriers": ["usps"],
}

results = client.smartrate.estimate_delivery_date(**params)

print(results)
