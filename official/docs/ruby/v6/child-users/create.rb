require 'easypost'

client = EasyPost::Client.new(api_key: 'EASYPOST_API_KEY')

user = client.user.create(
  name: 'Child Account Name',
)

puts user
