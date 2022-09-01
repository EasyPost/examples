import os

import easypost


easypost.api_key = os.getenv("EASYPOST_API_KEY")

api_keys = easypost.User.all_api_keys()

print(api_keys)
