import os

import easypost


client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

# Retrieve all API keys (authenticated user and child user keys)
api_keys = client.user.all_api_keys()

# Retrieve API keys for a child user
child_user = client.user.retrieve("user_...")
api_keys = child_user.api_keys()

print(api_keys)
