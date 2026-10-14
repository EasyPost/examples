import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

user = client.user.create(name="Child Account Name")

print(user)
