import easypost


easypost.api_key = "EASYPOST_API_KEY"

user = easypost.User.retrieve_me()

user = user.update_brand(color="#303F9F")

print(user)
