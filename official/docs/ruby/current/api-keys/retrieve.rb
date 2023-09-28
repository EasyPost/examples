require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

# Retrieve all API keys (authenticated user and child user keys)
api_keys = client.api_key.all

puts api_keys

# Retrieve API keys for a child user
child_user = client.user.retrieve('user_...')
child_api_keys = client.api_key.retrieve_api_keys_for_user(child_user.id)

puts child_api_keys
