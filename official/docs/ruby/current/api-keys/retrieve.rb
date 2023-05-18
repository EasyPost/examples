require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

# Retrieve all API keys (authenticated user and child user keys)
api_keys = client.user.all_api_keys

# Retrieve API keys for a child user
child_user = client.user.retrieve('user_...')
api_keys = client.user.api_keys(child_user.id)

puts api_keys
