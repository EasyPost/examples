import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

pickup = client.pickup.cancel("pickup_...")

print(pickup)
