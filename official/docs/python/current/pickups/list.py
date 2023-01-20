import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

pickups = easypost.Pickup.all(
    page_size=5,
)

print(pickups)
