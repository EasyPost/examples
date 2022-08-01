import easypost
easypost.api_key = "EASYPOST_API_KEY"

user = easypost.User.retrieve_me()

print(user)
