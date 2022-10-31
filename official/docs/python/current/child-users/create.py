import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

user = easypost.User.create(name="Child Account Name")

print(user)
