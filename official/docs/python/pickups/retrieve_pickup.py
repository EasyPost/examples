import easypost
easypost.api_key = "EASYPOST_API_KEY"

pickup = easypost.Pickup.retrieve("pickup_...")

print(pickup)
