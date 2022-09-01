import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

user = easypost.User.retrieve("user_...")

print(user)
