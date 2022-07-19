require 'easypost'

EasyPost.api_key = ENV['EASYPOST_API_KEY']

user = EasyPost::User.retrieve_me

color = '#303F9F'

brand = user.update_brand(
  color: color,
)

puts brand
