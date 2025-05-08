import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

brand = client.user.update_brand("user_...", color="#303F9F")

print(brand)
