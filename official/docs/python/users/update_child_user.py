import easypost


easypost.api_key = "EASYPOST_API_KEY"

user = easypost.User.retrieve("user_...")

user.name = "Test Child"

user.save()

print(user)
