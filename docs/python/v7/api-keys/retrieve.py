import easypost

easypost.api_key = "EASYPOST_API_KEY"

# Retrieve all API keys (authenticated user and child user keys)
api_keys = easypost.User.all_api_keys()

# Retrieve API keys for a child user
child_user = easypost.User.retrieve("user_...")
api_keys = child_user.api_keys()

print(api_keys)
