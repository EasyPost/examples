require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

# Retrieve the authenticated user
user = EasyPost::User.retrieve_me

# Retrieve a child user
user = EasyPost::User.retrieve('user_...')

puts user
