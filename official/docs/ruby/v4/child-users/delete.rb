require 'easypost'

EasyPost.api_key = 'EASYPOST_API_KEY'

user = EasyPost::User.retrieve('user_...')

user.delete

puts user
