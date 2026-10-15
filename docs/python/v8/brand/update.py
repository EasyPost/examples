import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

user = client.user.retrieve_me()

updated_brand = client.user.update_brand(user.id, color="#303F9F")

print(updated_brand)
