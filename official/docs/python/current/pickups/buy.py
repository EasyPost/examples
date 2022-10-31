import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")


pickup = easypost.Pickup.retrieve("pickup_...")
pickup.buy(
    carrier="UPS",
    service="Same-day Pickup",
)

print(pickup)
