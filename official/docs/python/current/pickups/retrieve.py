import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

pickup = client.pickup.retrieve("pickup_...")

print(pickup)
