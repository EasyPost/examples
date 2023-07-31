import easypost
import os

easypost.api_key = os.getenv("EASYPOST_API_KEY")

user = easypost.User.retrieve_me()

user.recharge_threshold = "50.00"

user.save()

print(user)
