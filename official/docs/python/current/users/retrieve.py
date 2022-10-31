import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

# Retrieve the authenticated user
user = easypost.User.retrieve_me()

# Retrieve a child user
user = easypost.User.retrieve("user_...")

print(user)
