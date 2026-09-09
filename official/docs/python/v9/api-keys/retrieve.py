import easypost

client = easypost.EasyPostClient("EASYPOST_API_KEY")

# Retrieve all API keys including children
api_keys = client.api_keys.all()

print(api_keys)

# Retrieve API keys for a specific child user
child_api_keys = client.api_keys.retrieve_api_keys_for_user("user_...")

print(child_api_keys)
