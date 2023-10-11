require 'easypost'

client = EasyPost::Client.new(api_key: ENV['EASYPOST_API_KEY'])

# Retrieve all API keys including children
api_keys = client.api_key.all

puts api_keys

# Retrieve API keys for a specific child user
child_api_keys = client.api_key.retrieve_api_keys_for_user('user_...')

puts child_api_keys
