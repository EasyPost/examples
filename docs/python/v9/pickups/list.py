import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

pickups = client.pickup.all(
    page_size=5,
)

print(pickups)
