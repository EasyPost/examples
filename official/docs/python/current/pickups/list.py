import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

pickups = client.pickup.all(
    page_size=5,
)

print(pickups)
