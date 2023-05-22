import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

pickup = easypost.Pickup.retrieve("pickup_...")

print(pickup)
