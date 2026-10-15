import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")


pickup = client.pickup.retrieve("pickup_...")

bought_pickup = client.pickup.buy(
    pickup.id,
    carrier="UPS",
    service="Same-day Pickup",
)

print(bought_pickup)
