import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

pickup = client.pickup.retrieve("pickup_...")

print(pickup)
