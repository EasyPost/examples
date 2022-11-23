require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

# Retrieve all API keys (authenticated user and child user keys)
api_keys = EasyPost::User.all_api_keys

# Retrieve API keys for a child user
child_user = EasyPost::User.retrieve('user_...')
api_keys = child_user.api_keys

puts api_keys
