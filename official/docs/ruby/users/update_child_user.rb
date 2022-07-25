require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

user = EasyPost::User.retrieve('user_...')

user.name = 'Test Child'

user.save

puts user
