import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

pickup = client.pickup.buy(
    "pickup_...",
    carrier="UPS",
    service="Same-day Pickup",
)

print(pickup)
