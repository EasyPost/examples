import easypost
import os

client = easypost.EasyPostClient(os.getenv("EASYPOST_API_KEY"))

# Retrieve all API keys including children
api_keys = client.api_key.all()

print(api_keys)

# Retrieve API keys for a specific child user
child_user = client.user.retrieve("user_...")
child_api_keys = client.api_key.retrieve_api_keys_for_user(child_user.id)

print(child_api_keys)
