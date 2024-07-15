import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

params = {
    "from_zip": "10001",
    "to_zip": "10002",
    "desired_delivery_date": "2024-07-18",
    "carriers": ["usps"],
}

results = client.smartrate.recommend_ship_date(**params)

print(results)
