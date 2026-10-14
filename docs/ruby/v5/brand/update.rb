require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

user = client.user.retrieve_me

brand = client.user.update_brand(
  user.id,
  color: '#303F9F',
)

puts brand
