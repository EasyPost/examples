require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

brand = client.user.update_brand(
  'user_...',
  color: '#303F9F',
)

puts brand
