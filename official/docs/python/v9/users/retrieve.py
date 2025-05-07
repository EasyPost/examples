import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

# Retrieve the authenticated user
user = client.user.retrieve_me()

# Retrieve a child user
user = client.user.retrieve("user_...")

print(user)
