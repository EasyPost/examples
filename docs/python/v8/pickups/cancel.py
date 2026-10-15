import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

pickup = client.pickup.retrieve("pickup_...")

cancelled_pickup = client.pickup.cancel(pickup.id)

print(cancelled_pickup)
